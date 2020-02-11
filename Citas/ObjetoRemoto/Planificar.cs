using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    [Serializable]
    [Table(Name = "Planificar")]
    public class Planificar
    {
        [Column(IsPrimaryKey = true)]
        public int Id_Planificar;

        [Column]
        public string Fecha_Reunion;

        [Column]
        public string Nombre_Comision;

        [Column]
        public string Tema_Tratar;

        [Column]
        public string Correos_Comision;

        public Planificar()
        {
        }

        public Planificar(string ini_fechaReunion)
        {
            Fecha_Reunion = ini_fechaReunion;
            Tema_Tratar = ini_fechaReunion;
        }

        public Planificar(int ini_idPlanificar, string ini_fechaReunion, string ini_nombreComision, string ini_temaTratar, string ini_correosComision)
        {
            Id_Planificar = ini_idPlanificar;
            Fecha_Reunion = ini_fechaReunion;
            Nombre_Comision = ini_nombreComision;
            Tema_Tratar = ini_temaTratar;
            Correos_Comision = ini_correosComision;
        }

        public override string ToString()
        {
            return Id_Planificar + Fecha_Reunion + Nombre_Comision + Tema_Tratar + Correos_Comision;
        }
    }
}