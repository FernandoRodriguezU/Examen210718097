using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
   public class IngresoDal
    {
        public DataTable LIstarIngresoDal()
        {
            string consulta = "SELECT p.NOMBRE, SUM(i.TOTAL) AS TotalIngresos\r\nFROM PROVEEDOR p\r\nINNER JOIN INGRESO i ON p.IDPROVEEDOR = i.IDPROVEEDOR\r\nGROUP BY p.NOMBRE;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
