using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [ServiceContract]
    public interface IObjetorRemoto
    {
        [OperationContract]
        int obtenerID_Comision(int id);
        [OperationContract]
        int obtenerID_Planificacion(int id);
        [OperationContract]
        List<Comision> selecionarComision(List<Comision> lista_comisiones);
        [OperationContract]
        List<Comision> selecionarCorreos(List<Comision> lista_correos);
        [OperationContract]
        List<Comision> crearComision(List<Comision> lista_agregarComision);
        [OperationContract]
        List<Planificar> guardarPlanificacion(List<Planificar> lista_planificaciones);
        [OperationContract]
        List<Comision> consultarPlanificacion(List<Comision> consulta_planificaciones);
        [OperationContract]
        List<Planificar> datosPlanificacion(List<Planificar> datosPlanificacion);
        [OperationContract]
        List<Planificar> consultaTema (List<Planificar> consultaTema);
    }
}