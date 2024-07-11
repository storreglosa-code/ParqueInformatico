using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Pantalla : Dispositivo
    {
        public new int Id { get; set; }

        public int TipoDispositivo { get; set; }

        public Pulgadas Pulgadas { get; set; }

        public EntradasVideo EntradasVideo { get; set; }

        public bool Wifi { get; set; }

    }
}
