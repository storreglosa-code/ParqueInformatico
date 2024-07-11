using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Impresora:Dispositivo
    {
        public new int Id { get; set; }

        public string Descripcion{ get; set; }

        public int TipoDispositivo { get; set; }

        public bool Wifi { get; set; }

    }
}
