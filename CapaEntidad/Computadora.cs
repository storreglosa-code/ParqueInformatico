using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Computadora:Dispositivo
    {
        public new int Id { get; set; }
        public string NombreComputadora { get; set; }
        public int TipoDispositivo{ get; set; }
        public Pantalla Pantalla { get; set; }

        public Mother Mother { get; set; }

        public Microprocesador Microprocesador { get; set; }

        public Memoria Memoria { get; set; }

        public Disco Disco { get; set; }

        public bool Wifi{ get; set; }

    }
}
