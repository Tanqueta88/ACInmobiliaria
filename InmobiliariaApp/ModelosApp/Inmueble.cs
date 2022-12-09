using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosPP
{
    public abstract class Inmueble
    {
        public double MtrsCuadrados {get; set;}
        public bool Urbano {get; set;}
        public int Cotizacion{
            get {
                if (this.Urbano) return 2000;
                return 3000;
            }
        }     
    }
}