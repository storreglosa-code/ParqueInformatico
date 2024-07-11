using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocios
{
    public class CN_Dependencia
    {
        private CD_Dependencia objCapaDato= new CD_Dependencia();

        public List<Dependencia> Listar()
        {
            return objCapaDato.Listar();
        }
    }
}
