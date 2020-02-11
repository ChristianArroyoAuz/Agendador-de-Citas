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
    [Table(Name = "Comision")]
    public class Comision
    {
        [Column(IsPrimaryKey = true)]
        public int Id_Comision;

        [Column]
        public string Nombre_Comision;

        [Column]
        public int Numero_Miembros;

        [Column]
        public string Nombre_Miembros;

        [Column]
        public string Cargo_Miembros;

        [Column]
        public string Correos_Comision;

        public Comision()
        {
        }

        public Comision(string ini_nombreComision)
        {
            Nombre_Comision = ini_nombreComision;
            Correos_Comision = ini_nombreComision;
            Cargo_Miembros = ini_nombreComision;
        }

        public Comision(int ini_idComision, string ini_nombreComision, int ini_numeroMiembros, string ini_nombreMiembros, string ini_cargoMiembros, string ini_correosComision)
        {
            Id_Comision = ini_idComision;
            Nombre_Comision = ini_nombreComision;
            Numero_Miembros = ini_numeroMiembros;
            Nombre_Miembros = ini_nombreMiembros;
            Cargo_Miembros = ini_cargoMiembros;
            Correos_Comision = ini_correosComision;
        }

        public override string ToString()
        {
            return Id_Comision + Nombre_Comision + Numero_Miembros + Nombre_Miembros + Cargo_Miembros + Correos_Comision;
        }
    }
}