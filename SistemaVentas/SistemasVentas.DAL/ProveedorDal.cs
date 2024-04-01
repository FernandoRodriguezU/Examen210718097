using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public  class ProveedorDal
    {
        public DataTable LIstarProveedorDal()
        {
            string consulta = "SELECT tp.NOMBRE AS TipoProducto, SUM(dv.CANTIDAD) AS CantidadTotalVendida\r\nFROM TIPOPROD tp\r\nINNER JOIN PRODUCTO p ON tp.IDTIPOPROD = p.IDTIPOPROD\r\nINNER JOIN DETALLEVENTA dv ON p.IDPRODUCTO = dv.IDPRODUCTO\r\nGROUP BY tp.NOMBRE;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
      

    }
}
