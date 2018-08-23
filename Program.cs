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
            char tipo=' ';
            string pstring;

            Comercial Avioncito = new Comercial();

            Console.WriteLine("Escoge el tipo de avion: \na>Comercial\nb)Militar\nc)Carga");
            tipo = Console.ReadKey().KeyChar;

            if (tipo == 'a' || tipo == 'A')
            {
                Console.Clear();
                Console.WriteLine("¿Cuál es tu número de pasajero?");
                pstring = Console.ReadLine(); 
                Avioncito.p = Convert.ToInt16(pstring);
                if (Avioncito.p <= 0 || Avioncito.p > 200)
                {
                    Console.Clear();
                    Console.WriteLine("Error, no existe ese número de pasajero");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nTu avión es de tipo comercial \nModelo: {0} \nNúmero de pasajero: {1}\nMotores: {2}\nEstado:", Avioncito.SetModelo(), Avioncito.p, Avioncito.SetNummotores());
                    Avioncito.Volar();
                    Console.WriteLine("Velocidad: {0} Km/h", Avioncito.SetVelovidad());
                    Console.ReadKey();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Avión no disponible");
                Console.ReadKey();
            }

        }
    }
}
