using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.BSS
{
    public  class MarcaBss
    {
        MarcaDal dal = new MarcaDal();
        public DataTable ListarMarcaBss()
        {

            return dal.LIstarMarcaDal();
        }
    }
}
