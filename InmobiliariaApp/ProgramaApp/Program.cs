using ModelosPP;

var inmueble1=new Casa();
inmueble1.MtrsCuadrados=1900;
inmueble1.Cochera=true;
inmueble1.Pileta=true;
inmueble1.Urbano=true; 


var inmueble2 = new LocalComercial();
inmueble2.MtrsCuadrados = 1800;
inmueble2.Urbano = false;
inmueble2.Impuestos = true;

var inmueble3 = new LocalComercial();
inmueble3.MtrsCuadrados = 1800;
inmueble3.Urbano = false;
inmueble3.Impuestos = true;

var inmueble4 = new LocalComercial();
inmueble4.MtrsCuadrados = 1800;
inmueble4.Urbano = false;
inmueble4.Impuestos = false;

var inmueble5=new Casa();
inmueble5.MtrsCuadrados=1900;
inmueble5.Cochera=false;
inmueble5.Pileta=false;
inmueble5.Urbano=false; 

var inmobiliariaObjetos = new Inmobiliaria();
inmobiliariaObjetos.Agregar(inmueble1);

inmobiliariaObjetos.Agregar(inmueble2);

inmobiliariaObjetos.Agregar(inmueble3);

inmobiliariaObjetos.Agregar(inmueble4);

inmobiliariaObjetos.Agregar(inmueble5);

inmobiliariaObjetos.Imprimir();


