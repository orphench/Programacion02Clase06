using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase06
{
    class Program
    {
        static void Main(string[] args)
        {
            //REPASO
            Persona unaPersona = new Persona("Jose");
            Fabrica unaAutomotriz = new Fabrica("Ford");
            Vehiculo unAuto = new Vehiculo(unaPersona, unaAutomotriz, "2016");

            Console.Write(unaAutomotriz.nombre);
            Console.Write(unAuto.dueño.nombre);

            unAuto = "2017";

            Persona A = new Persona("");
            Persona B = new Persona("");
            B.nombre = "JOSE";
            A.nombre = B.nombre;
            Persona C = new Persona("");
            C = A;
            A.nombre = B.nombre;
            B.nombre = "MARIA";
            Console.Write(C.nombre);//DEVUELVE JOSE

            Console.Clear();

            Fabrica Fab = new Fabrica("FORD");
            Vehiculo uno = new Vehiculo("2016");
            Vehiculo dos = new Vehiculo("1990");

            Fab.Agregar(uno);
            Fab.Agregar(dos);
            Fab.Agregar(new Vehiculo("2000"));
            uno.año = "1990";
            Fab.Mostrar();

            Vehiculo tres = new Vehiculo("1980");
            uno = dos; //SE PIERDE LA REFENCIA
            dos.año = "1970";
            uno = tres;
            tres.año = "1950";
            uno.año = "1900";

            dos = tres;

            Fab.Mostrar();

            foreach (Vehiculo item in Fab.ListaDeVehiculos)
            {
                item.año = dos.año;
            }
            Fab.Mostrar();
            dos.año = "2222";
            Fab.Mostrar();

            for (int i = 0; i < Fab.ListaDeVehiculos.Count; i++)
            {
                //Fab.ListaDeVehiculos[i] = new Vehiculo("666");
                Fab.ListaDeVehiculos[i] = dos;
            }

            dos.año = "1234";
            Fab.Mostrar();

            Console.ReadKey();
        }
    }
}
