using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class VentaDal
    {
        public DataTable LIstarVentaDal()
        {
            string consulta = "select * from venta";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
