using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeronaves
{
    class Comercial : Avion
    {
        int pasajeros;
        public int p;
        public string SetModelo()
        {
            return (modelo= "Boeing 777");
        }
        public int SetNummotores()
        {
            return (nummotores = 2);
        }
        public double SetVelovidad()
        {
            return (velocidad= 905);
        }
        public void GetPasajeros(int p)
        {
            pasajeros = p;
        }
    }
}
