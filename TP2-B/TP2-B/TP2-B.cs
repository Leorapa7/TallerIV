using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_B
{
    class TP2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Auto 1");
            Automovil auto1 = new Automovil(new Motor(16), new CajaDeCambio(tipoCajaCambio.manual, 5));
            auto1.agregarRuedas(5, 40);
            auto1.getEspecificaciones();

            Console.WriteLine("Auto 2");
            Automovil auto2 = new Automovil(new Motor(12), new CajaDeCambio(tipoCajaCambio.automatica, 5));
            auto2.agregarRuedas(4, 50);
            auto2.getEspecificaciones();

            Console.WriteLine("Auto 3");
            Automovil auto3 = new Automovil(new Motor(18), new CajaDeCambio(tipoCajaCambio.automatica, 6));
            auto3.agregarRuedas(7, 50);
            auto3.getEspecificaciones();

            Console.WriteLine("Auto 4");
            Automovil auto4 = new Automovil(new Motor(16), new CajaDeCambio(tipoCajaCambio.manual, 6));
            auto4.agregarRuedas(5, 30);
            auto4.getEspecificaciones();

            Console.ReadKey();
        }
    }
}
