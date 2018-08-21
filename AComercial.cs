using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves
{
    class AComercial: Avion
    {
        int pasajeros;
        string stringpasajeros;
        public void GetModelo()
        {
            modelo= Console.ReadLine();
        }
        public void GetPeso()
        {
            stringpeso = Console.ReadLine();
            peso = Convert.ToDouble(stringpeso);
        }
        public void GetPasajeros()
        {
            stringpasajeros = Console.ReadLine();
            pasajeros = Convert.ToInt16(stringpeso);
        }
}
