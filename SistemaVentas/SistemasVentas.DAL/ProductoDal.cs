using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ProductoDal
    {
        public DataTable LIstarProductoDal()
        {
            string consulta = "SELECT p.IDPRODUCTO, p.NOMBRE AS NombreProducto, tp.NOMBRE AS TipoProducto, m.NOMBRE AS Marca,\r\n       p.CODIGOBARRA AS CodigoDeBarras, p.UNIDAD AS CantidadEnInventario, p.DESCRIPCION AS Descripcion\r\nFROM PRODUCTO p\r\nINNER JOIN TIPOPROD tp ON p.IDTIPOPROD = tp.IDTIPOPROD\r\nINNER JOIN MARCA m ON p.IDMARCA = m.IDMARCA;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
