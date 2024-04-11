using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Dominio
{
    internal class Auto
    {
        public double cKilometros {  get; set; }
        public double comustible {  get; set; }
        public int capacidad { get; set; }
        public double combustibleACargar {  get; set; }
        public Auto()
        {
            this.capacidad = 54;
        }
          
        public bool Conducir()
        {
            bool prodra = false;
            if (comustible * 11 >= cKilometros ) 
            {
                prodra = true;
            }
            
            return prodra;
        }

        public double CargarCombustible()
        {
            double perdio = 0;
            if (combustibleACargar + comustible > capacidad)
            {
                perdio = (combustibleACargar + comustible) - capacidad;
            }
            return perdio;
        }
    }
}
