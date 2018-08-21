using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves
{
    class Avion
    {
        protected double peso, carga, velocidadmax;
        protected string stringpeso, modelo;
        protected int nummotor;

        public Avion()
        {

        stringpeso= " ";
        peso = 0;
        carga = 0;
        velocidadmax = 0;
        modelo = " ";
        nummotor = 0;
        }

        public void Despegar ()   
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
        public void Acelerar()
        {
            Console.WriteLine("Esta acelerando");
        }
        public void Disparar()
        {
            Console.WriteLine("Piu Piu, esta disparando");
        }
        public void SoltarCarga()
        {
            Console.WriteLine("Esta Soltando la carga");
        }
    }
