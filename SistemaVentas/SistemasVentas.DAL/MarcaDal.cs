using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class MarcaDal
    {
        public DataTable LIstarMarcaDal()
        {
            string consulta = "SELECT TOP 1 m.NOMBRE AS NombreMarca, COUNT(*) AS CantidadProductosVendidos\r\nFROM MARCA m\r\nINNER JOIN PRODUCTO p ON m.IDMARCA = p.IDMARCA\r\nINNER JOIN DETALLEVENTA dv ON p.IDPRODUCTO = dv.IDPRODUCTO\r\nGROUP BY m.NOMBRE\r\nORDER BY COUNT(*) DESC;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
