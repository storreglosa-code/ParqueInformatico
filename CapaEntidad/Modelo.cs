using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Modelo
    {

        public int Id { get; set; }

        public string Descripcion { get; set; }

        public string TipoDispositivo { get; set; }

        public Marca Marca { get; set; }
    }
}
