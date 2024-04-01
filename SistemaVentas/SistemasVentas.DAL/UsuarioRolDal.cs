using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class UsuarioRolDal
    {
        public DataTable LIstarUsuarioRolDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO, SUM(v.TOTAL) AS TotalCompras\r\nFROM PERSONA p\r\nINNER JOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA\r\nINNER JOIN VENTA v ON c.IDCLIENTE = v.IDCLIENTE\r\nGROUP BY p.NOMBRE, p.APELLIDO\r\nHAVING SUM(v.TOTAL) >1;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
