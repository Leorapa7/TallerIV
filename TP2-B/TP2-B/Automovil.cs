using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_B
{
    class Automovil
    {
        private List<Rueda> ruedas = new List<Rueda>();
        private Motor motor;
        private CajaDeCambio cajaCambios;

        public Automovil(Motor m, CajaDeCambio cdc)
        {
            motor = m;
            cajaCambios = cdc;
        }

        public void agregarRuedas(int cantidad, double diametro)
        {
            if (cantidad < 6)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    ruedas.Add(new Rueda(diametro));
                }
            }else{
                Console.WriteLine("No puede tener más de 6 ruedas, por lo que se agrega la cantidad max.");
                for (int i = 0; i < 6; i++)
                {
                    ruedas.Add(new Rueda(diametro));
                }
            }

        }

        public void getEspecificaciones()
        {
            Console.WriteLine("El auto contiene: ");
            Console.WriteLine("Motor de "+ motor.cilindrada +"CC de cilindrada");
            Console.WriteLine("Caja "+ cajaCambios.tipo + " de " + cajaCambios.cantidadCambios + " cambios");
            Console.WriteLine(ruedas.Count + " ruedas de "+ ruedas[0].diametro + " de diametro");

        }
    }
}