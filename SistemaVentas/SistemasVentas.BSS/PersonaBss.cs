using SistemasVentas.DAL;
using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public class PersonaBss
    {
        PersonaDal dal= new PersonaDal();
        public DataTable ListarPersonaBss()
        {

            return dal.LIstarPersonasDal();
        }
        public void InsertarPersonaBss(Persona persona)
        {
            dal.InsertarPersonaDAL(persona);
        }
        public Persona ObtenerIdBss(int id)
        {
            return dal.ObtenerPersonaId(id);
        }
        public void EditarPersonaBss(Persona p)
        {
            dal.EditarPersonaDal(p);
        }
        public void EliminarPersonBss(int id)
        {
            dal.EliminarPersonaDal(id);
        }
    }
}
