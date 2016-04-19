using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase06
{
    class Fabrica
    {
        public string nombre;
        public List<Vehiculo> ListaDeVehiculos;

        public Fabrica(string nombre)
        {
            this.nombre = nombre;
            this.ListaDeVehiculos = new List<Vehiculo>();
        }

        public void Agregar(Vehiculo unVehiculo)
        {
            this.ListaDeVehiculos.Add(unVehiculo);
            
        }

        public void Mostrar()
        {
            foreach (Vehiculo item in this.ListaDeVehiculos)
            {
                Console.WriteLine(item.año);
            }
        }
    }
}
