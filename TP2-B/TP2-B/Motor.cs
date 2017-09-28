using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_B
{
    class Motor : InterfaceMovilidad
    {
        public int cilindrada { get; set; }

        public Motor(int cilindrada)
        {
            this.cilindrada = cilindrada;
        }

        public void inicar()
        {
            Console.WriteLine("Motor frenado");
        }

        public void frenar()
        {
            Console.WriteLine("Motor arrancando");
        }
    }
}
