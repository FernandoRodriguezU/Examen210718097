using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable LIstarClienteDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO\r\nFROM PERSONA p\r\nINNER JOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = " SELECT p.NOMBRE, p.APELLIDO\r\nFROM PERSONA p\r\nINNER JOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA;\r\n";
            conexion.Ejecutar(consulta);
        }
    }
}

