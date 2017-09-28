using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_B
{
    class Rueda : InterfaceMovilidad
    {
        public double diametro { get; set; }

        public Rueda(double diametro)
        {
            this.diametro = diametro;
        }

        public void inicar()
        {
            Console.WriteLine("Rueda frenado");
        }

        public void frenar()
        {
            Console.WriteLine("Rueda andando");
        }
    }
}