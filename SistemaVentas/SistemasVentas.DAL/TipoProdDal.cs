using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class TipoProdDal
    {
        public DataTable LIstarTipoProdDal()
        {
            string consulta = "SELECT d.IDPRODUCTO, p.NOMBRE AS NombreProducto, d.FECHAVENC, d.CANTIDAD\r\nFROM DETALLEING d\r\nINNER JOIN PRODUCTO p ON d.IDPRODUCTO = p.IDPRODUCTO\r\nWHERE d.FECHAVENC <= DATEADD(MONTH, 1, GETDATE());\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
