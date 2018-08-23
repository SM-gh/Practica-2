using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves
{
    class Avion
    {
        protected double peso, carga, velocidad;
        protected string  modelo;
        protected int nummotores;

        public Avion()
        {
            peso = 0;
            carga = 0;
            velocidad = 0;
            modelo = " ";
            nummotores = 0;
        }
        public void Acelerar()
        {
            Console.WriteLine("Esta acelerando");
        }
        public void Despegar()
        {
            Console.WriteLine("Esta despagando");
        }
        public void Volar()
        {
            Console.WriteLine("Esta volando");
        }
        public void Aterrizar()
        {
            Console.WriteLine("Esta aterrizando");
        }
        public void Disparar()
        {
            Console.WriteLine("Piu, Piu. Esta disparando");
        }
        public void SoltarCarga()
        {
            Console.WriteLine("Esta soltando la carga");
        }
        public void BuscaObjetivo()
        {
            Console.WriteLine("Esta sbuscamdo el objetivo");
        }
    }
}
