using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosPP
{
    public class LocalComercial : Inmueble
    {
        public bool Impuestos {get;set;}
        public double Cotizar(){
            if(this.Impuestos) return Cotizacion - (Cotizacion * 0.10);
            return Cotizacion;       
        }            
    }
}

