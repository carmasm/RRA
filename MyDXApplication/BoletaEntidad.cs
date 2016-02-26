using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDXApplication
{
    public class BoletaEntidad
    {
        public string SerieBoleta { get; set; }
        public int NumeroBoleta { get; set; }
        public DateTime Fecha { get; set; }
        public string Bascula { get; set; }
        public string DireccionIp { get; set; }
        public decimal Bruto { get; set; }
        public decimal Tara { get; set; }
        public decimal Neto { get; set; }
    }
}
