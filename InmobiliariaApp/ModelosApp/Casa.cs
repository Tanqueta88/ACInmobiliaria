using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosPP
{
    public class Casa : Inmueble
    {
        public bool Pileta {get;set;}
        public bool Cochera {get;set;}
    
        public double Cotizar(){
            double temp = Cotizacion;
            if(this.Pileta) temp += 200;
            if(this.Cochera) temp += 50;
            return temp;       
        }
    }
}