using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System;

namespace ObjetoRemoto
{
    class miDB : DataContext
    {
        public Table<Planificar> Planificar;
        public Table<Comision> Comision;
        public miDB() : base(@"C:\CADENA_DE_COEXIÓN\MIDB.MDF;Integrated Security=True") { }
    }
}