using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class ProveeDal
    {
        public DataTable LIstarProveeDal()
        {
            string consulta = "SELECT TOP 1 p.NOMBRE AS NombreProveedor, COUNT(pr.IDPRODUCTO) AS CantidadProductosSuministrados\r\nFROM PROVEEDOR p\r\nINNER JOIN PROVEE pr ON p.IDPROVEEDOR = pr.IDPROVEEDOR\r\nGROUP BY p.NOMBRE\r\nORDER BY COUNT(pr.IDPRODUCTO) DESC;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
    }
}
