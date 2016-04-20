using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDXApplication
{
    public class Bascula
    {
        public Bascula()
        { 
        }

        public Bascula(int sipBecamo_BasculasId, string descripcion, string direccionIp, string ubicacion, string blt_Proceso,
                                string blt_Periodo, string blt_Bodega, string blt_Orden, string blt_Procede, string blt_Bloque, string blt_Calidad,
                                        string blt_Calidad_Interna, string marca)
        {
            SipBecamo_BasculasId = sipBecamo_BasculasId;
            Descripcion = descripcion;
            DireccionIp = direccionIp;
            Ubicacion = ubicacion;
            Blt_Proceso = blt_Proceso;
            Blt_Periodo = blt_Periodo;
            Blt_Bodega = blt_Bodega;
            Blt_Orden = blt_Orden;
            Blt_Procede = blt_Procede;
            Blt_Bloque = blt_Bloque;
            Blt_Calidad = blt_Calidad;
            Blt_Calidad_Interna = blt_Calidad_Interna;
            Marca = marca;
        }

        public int SipBecamo_BasculasId { get; set; }
        public string Descripcion { get; set; }
        public string DireccionIp { get; set; }
        public string Ubicacion { get; set; }
        public string Blt_Proceso { get; set; }
        public string Blt_Periodo { get; set; }
        public string Blt_Bodega { get; set; }
        public string Blt_Orden { get; set; }
        public string Blt_Procede { get; set; }
        public string Blt_Bloque { get; set; }
        public string Blt_Calidad { get; set; }
        public string Blt_Calidad_Interna { get; set; }
        public string Marca { get; set; }
    }
}
