using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleIngDal
    {
        public DataTable LIstarDetalleIngDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO, SUM(v.TOTAL) AS TotalIngresos\r\nFROM PERSONA p\r\nINNER JOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA\r\nINNER JOIN VENTA v ON c.IDCLIENTE = v.IDCLIENTE\r\nGROUP BY p.NOMBRE, p.APELLIDO;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
