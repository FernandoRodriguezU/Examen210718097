using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentas.Modelos;

namespace SistemasVentas.DAL
{
    public class PersonaDal
    {
        public DataTable LIstarPersonasDal()
        {
            string consulta = "SELECT p.NOMBRE, p.APELLIDO\r\nFROM PERSONA p\r\nINNER JOIN CLIENTE c ON p.IDPERSONA = c.IDPERSONA;\r\n";
            DataTable lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;

        }
        public void InsertarPersonaDAL(Persona persona)
        {
            string consulta = "insert into persona values('" + persona.Nombre + "'," +
                                                          "'" + persona.Apellido + "'," +
                                                          "'" + persona.Telefono + "'," +
                                                          "'" + persona.Ci + "'," +
                                                          "'" + persona.Correo + "'," +
                                                          "'Activo')";
            conexion.Ejecutar(consulta);
        }

        public Persona ObtenerPersonaId(int id)
        {
            string consulta = "select * from persona where idpersona=" + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "asdas");
            Persona p = new Persona();
            if (tabla.Rows.Count > 0)
            {
                p.IdPersona = Convert.ToInt32(tabla.Rows[0]["Idpersona"]);
                p.Nombre = tabla.Rows[0]["nombre"].ToString();
                p.Apellido = tabla.Rows[0]["apellido"].ToString();
                p.Telefono = tabla.Rows[0]["telefono"].ToString();
                p.Ci = tabla.Rows[0]["ci"].ToString();
                p.Correo = tabla.Rows[0]["correo"].ToString();
                p.Estado = tabla.Rows[0]["estado"].ToString();
            }
            return p;

        }
        public void EditarPersonaDal(Persona p)
        {
            string consulta = "update persona set nombre='" + p.Nombre + "'," +
                                                 "apellido='" + p.Apellido + "'," +
                                                 "telefono='" + p.Telefono + "'," +
                                                 "ci='" + p.Ci + "'," +
                                                 "correo='" + p.Correo + "' " +
                               "where idpersona=" + p.IdPersona;
            conexion.Ejecutar(consulta);
        }
        public void EliminarPersonaDal(int id)
        {
            string consulta = "delete from persona where idpersona=" + id;
            conexion.Ejecutar(consulta);
        }

    }
}
