using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion02Clase06
{
    class Vehiculo
    {
        public string año;
        public Persona dueño;
        public Fabrica fabric;

        public Vehiculo(string año)
        {
            this.año = año;
        }

        static Vehiculo()
        {

        }

        //public Vehiculo(Persona dueño)
        //{
        //    this.dueño = dueño;
        //}

        public Vehiculo(Persona dueño, Fabrica fabric, string año):this(año)
        {
            this.dueño = dueño;
            this.fabric = fabric;
            //this.año = año;
        }

        public static implicit operator Vehiculo(string año)
        {
            return new Vehiculo(año);
        }

        //public static implicit operator Vehiculo(Persona dueño)
        //{
        //    return new Vehiculo(dueño);
        //}
    }
}
