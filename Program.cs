using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo = " ";

            Console.WriteLine("Da el modelo del avión comercial:");
            tipo = Console.ReadLine();

            Avion Avioncito = new AComercial(AComercial.modelo);

            Console.WriteLine("La es un avion tipo comercial, modelo {0}", );
            Console.ReadKey();
        }
    }
}
