using SistemasVentas.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasVentas.BSS;
using SistemaVentas.Modelos;

namespace SistemasVentas.BSS
{
    public  class ProveedorBss
    {
        ProveedorDal dal = new ProveedorDal();
        public DataTable ListarProveedorBss()
        {

            return dal.LIstarProveedorDal();
        }
       
    }
}
