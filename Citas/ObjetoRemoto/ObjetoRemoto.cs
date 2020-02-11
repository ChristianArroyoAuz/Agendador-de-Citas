using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class ObjetoRemoto : MarshalByRefObject, IObjetorRemoto
    {
        public string fechaPlanificacion, nombreComision, temaTratar, correosComision, nombreMiembros, cargoMiembros, consultaActa, busquedaCorreo;
        public int identificadorComision, identificadorComision_Agregar, identificadorPlanificacion, numeroMiembros, consultaDatosPlanificar;
        public List<Planificar> mostrarPlanificaciones = new List<Planificar>();
        public List<Comision> consutaPlanificaciones = new List<Comision>();
        public List<Comision> mostrarComisiones = new List<Comision>();
        public List<Comision> mostrarCorreos = new List<Comision>();
        miDB miBase = new miDB();
        
        public int obtenerID_Comision(int id)
        {
            var consulta = (from usuarios in miBase.Comision
                            where usuarios.Id_Comision > id
                            orderby usuarios.Id_Comision descending
                            select (int)usuarios.Id_Comision).Take(1);
            foreach (var identificador in consulta)
            {
                id = identificador;
                identificadorComision = id;
            }
            return (identificadorComision + 1);
        }

        public int obtenerID_Planificacion(int id)
        {
            var consulta = (from planificacion in miBase.Planificar
                            where planificacion.Id_Planificar > id
                            orderby planificacion.Id_Planificar descending
                            select (int)planificacion.Id_Planificar).Take(1);
            foreach (var identificador in consulta)
            {
                id = identificador;
                identificadorPlanificacion = id;
            }
            return (identificadorPlanificacion + 1);
        }

        public List<Comision> selecionarComision(List<Comision> lista_comisiones)
        {
            var consulta = (from comision in miBase.Comision
                            where comision.Id_Comision > 0
                            select comision.Nombre_Comision).Distinct();
            foreach (var item in consulta)
            {
                Comision cargar = new Comision(item);
                lista_comisiones.Add(cargar);
                mostrarComisiones = lista_comisiones;
            }
            return mostrarComisiones;
        }

        public List<Comision> selecionarCorreos(List<Comision> lista_correos)
        {
            var consulta = (from comision in miBase.Comision
                            where comision.Nombre_Comision == busquedaCorreo
                            orderby comision.Id_Comision ascending
                            select new
                            {
                                ID = comision.Id_Comision,
                                NOMBRE_COMISION = comision.Nombre_Comision,
                                NUMERO_MIEMBROS = comision.Numero_Miembros,
                                NOMBRE_MIEMBROS = comision.Nombre_Miembros,
                                CARGO_MIEMBROS = comision.Cargo_Miembros,
                                CORRREOS_COMISION = comision.Correos_Comision
                            }).Distinct();
            foreach (var item in consulta)
            {
                Comision cargar = new Comision(item.ID, item.NOMBRE_COMISION, item.NUMERO_MIEMBROS, item.NOMBRE_MIEMBROS, item.CARGO_MIEMBROS, item.CORRREOS_COMISION);
                lista_correos.Add(cargar);
                mostrarCorreos = lista_correos;
            }
            return mostrarCorreos;
        }

        public List<Comision> crearComision(List<Comision> lista_agregarComision)
        {
            Comision nuevaComision = new Comision(identificadorComision_Agregar, nombreComision, numeroMiembros, nombreMiembros, cargoMiembros, correosComision);
            nuevaComision.Id_Comision = identificadorComision_Agregar;
            nuevaComision.Nombre_Comision = nombreComision;
            nuevaComision.Numero_Miembros = numeroMiembros;
            nuevaComision.Nombre_Miembros = nombreMiembros;
            nuevaComision.Cargo_Miembros = cargoMiembros;
            nuevaComision.Correos_Comision = correosComision;
            miBase.Comision.InsertOnSubmit(nuevaComision);
            miBase.SubmitChanges();
            var consulta = from comision in miBase.Comision
                           where comision.Nombre_Comision == nombreComision
                           select new
                           {
                               ID = comision.Id_Comision,
                               NOMBRE_COMISION = comision.Nombre_Comision,
                               NUMERO_MIEMBROS = comision.Numero_Miembros,
                               NOMBRE_MIEMBROS = comision.Nombre_Miembros,
                               CARGO_MIEMBROS = comision.Cargo_Miembros,
                               CORRREOS_COMISION = comision.Correos_Comision
                           };
            foreach (var item in consulta)
            {
                Comision cargar = new Comision(item.ID, item.NOMBRE_COMISION, item.NUMERO_MIEMBROS, item.NOMBRE_MIEMBROS, item.CARGO_MIEMBROS, item.CORRREOS_COMISION);
                lista_agregarComision.Add(cargar);
                mostrarComisiones = lista_agregarComision;
            }
            return mostrarComisiones;
        }

        public List<Planificar> guardarPlanificacion(List<Planificar> lista_planificaciones)
        {
            Planificar nuevaPlanificacion = new Planificar(identificadorPlanificacion, fechaPlanificacion, nombreComision, temaTratar, correosComision);
            nuevaPlanificacion.Id_Planificar = identificadorPlanificacion;
            nuevaPlanificacion.Fecha_Reunion = fechaPlanificacion;
            nuevaPlanificacion.Nombre_Comision = nombreComision;
            nuevaPlanificacion.Tema_Tratar = temaTratar;
            nuevaPlanificacion.Correos_Comision = correosComision;
            miBase.Planificar.InsertOnSubmit(nuevaPlanificacion);
            miBase.SubmitChanges();
            var consulta = from planificacion in miBase.Planificar
                           where planificacion.Id_Planificar == identificadorPlanificacion
                           select new
                           {
                               ID = planificacion.Id_Planificar,
                               FECHA_REUNION = planificacion.Fecha_Reunion,
                               NOMBRE_COMISION = planificacion.Nombre_Comision,
                               TEMA_TRATAR = planificacion.Tema_Tratar,
                               CORREOS_COMISION = planificacion.Correos_Comision
                           };
            foreach (var item in consulta)
            {
                Planificar cargar = new Planificar(item.ID, item.FECHA_REUNION, item.NOMBRE_COMISION, item.TEMA_TRATAR, item.CORREOS_COMISION);
                lista_planificaciones.Add(cargar);
                mostrarPlanificaciones = lista_planificaciones;
            }
            return mostrarPlanificaciones;
        }

        public List<Comision> consultarPlanificacion(List<Comision> consulta_planificaciones)
        {
            var consulta = (from planificacion in miBase.Comision
                            where planificacion.Nombre_Comision == consultaActa
                            select planificacion.Nombre_Comision).Distinct();
            foreach (var item in consulta)
            {
                Comision cargar = new Comision(item);
                consulta_planificaciones.Add(cargar);
                consutaPlanificaciones = consulta_planificaciones;
            }
            return consutaPlanificaciones;
        }

        public List<Planificar> datosPlanificacion(List<Planificar> datosPlanificacion)
        {
            var consulta = (from planificacion in miBase.Planificar 
                            where planificacion.Id_Planificar == consultaDatosPlanificar
                            select planificacion.Fecha_Reunion).Distinct();
            foreach (var item in consulta)
            {
                Planificar cargar = new Planificar(item);
                datosPlanificacion.Add(cargar);
                mostrarPlanificaciones = datosPlanificacion;
            }
            return mostrarPlanificaciones;
        }

        public List<Planificar> consultaTema(List<Planificar> consultaTema)
        {
            var consulta = (from planificacion in miBase.Planificar
                            where planificacion.Id_Planificar == consultaDatosPlanificar
                            select planificacion.Tema_Tratar).Distinct();
            foreach (var item in consulta)
            {
                Planificar cargar = new Planificar(item);
                consultaTema.Add(cargar);
                mostrarPlanificaciones = consultaTema;
            }
            return mostrarPlanificaciones;
        }
    }
}