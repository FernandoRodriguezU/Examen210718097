using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class DetalleVentaDal
    {
        public DataTable LIstarDetalleVentaDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO, COUNT(*) AS CantidadProductosVendidos\r\nFROM PERSONA p\r\nINNER JOIN USUARIO u ON p.IDPERSONA = u.IDPERSONA\r\nINNER JOIN VENTA v ON u.IDUSUARIO = v.IDVENDEDOR\r\nINNER JOIN DETALLEVENTA dv ON v.IDVENTA = dv.IDVENTA\r\nGROUP BY p.NOMBRE, p.APELLIDO;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
