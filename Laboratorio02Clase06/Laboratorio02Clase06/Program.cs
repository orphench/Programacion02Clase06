using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio02Clase06
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente unCliente = new Cliente(eTipoCliente.EmpresarioCorrupto, "Pepito", "Argentina");

            Console.WriteLine(unCliente);
        }
    }
}
