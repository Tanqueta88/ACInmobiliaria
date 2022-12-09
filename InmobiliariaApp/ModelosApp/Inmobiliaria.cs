using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModelosPP
{
    public class Inmobiliaria
    {
        private List<Inmueble> ListInmuebles = new List<Inmueble>();

        public void Agregar(Inmueble inmueble){
            ListInmuebles.Add(inmueble);
        }
        public void Imprimir(){
            for (int i = 0; i < ListInmuebles.Count; i++){
                if (ListInmuebles[i].GetType() == typeof(Casa)) {
                    Casa casa = (Casa) ListInmuebles[i];
                    Console.WriteLine($"El inmueble de la posicion {i+1} es una casa");
                    Console.WriteLine($"La casa{(casa.Pileta ? "" : " no")} tiene pileta.");
                    Console.WriteLine($"La casa{(casa.Cochera ? "" : " no")} tiene cochera.");
                    Console.WriteLine($"La cotizacion del inmueble es: {casa.Cotizar()}");
                }
                else{
                    LocalComercial local  = (LocalComercial) ListInmuebles[i];
                    Console.WriteLine($"El inmueble de la posicion {i+1} es un local comercial");
                    Console.WriteLine($"El local comercial{(local.Impuestos ? "" : " no")} tiene impuestos.");
                    Console.WriteLine($"La cotizacion del inmueble es: {local.Cotizar()}");
                }
                Console.WriteLine("");
            }
        }
    }
}