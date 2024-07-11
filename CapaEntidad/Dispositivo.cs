using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Dispositivo
    {
        public int Id { get; set; }

        public Marca Marca { get; set; }

        public Modelo Modelo { get; set; }

        public Formato Formato { get; set; }

        public Dependencia Dependencia { get; set; }

        public DateTime FechaAdquisicion { get; set; }

        public DateTime FechaBaja { get; set; }

        public bool Estado { get; set; }

        public string Detalle { get; set; }

        public string Serial { get; set; }



    }
}
