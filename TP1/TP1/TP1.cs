using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la opción que desea");
            Console.WriteLine("1 - nombreApellido");
            Console.WriteLine("2 - esMayor");
            Console.WriteLine("3 - sumaAnterior");
            Console.WriteLine("4 - maximoComunDivisor");
            Console.WriteLine("5 - calcularPromedio");
            var rta = Console.ReadLine();
            switch (rta)
            {
                case "1":
                    nombreApellido();
                    break;
                case "2":
                    esMayor();
                    break;
                case "3":
                    sumaAnterior();
                    break;
                case "4":
                    maximoComunDivisor();
                    break;
                case "5":
                    calcularPromedio();
                    break;
                default:
                    break;
            }

        }//CIERRA EL STATIC

        public static void nombreApellido()
        {
            Console.WriteLine("Ingrese nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            var apellido = Console.ReadLine();
            Console.WriteLine(nombre + " " + apellido);
            Console.ReadKey();
        }

        public static void esMayor()
        {
            Console.WriteLine("Ingrese nombre");
            var nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            var edad = Console.ReadLine();

            if (int.Parse(edad) < 18)
            {
                Console.WriteLine(nombre2 + " Es menor de edad");
            }
            else
            {
                Console.WriteLine(nombre2 + " Es mayor de edad");
            }
            Console.ReadKey();
        }

        public static void sumaAnterior()
        {
            int suma = 0;
            Console.WriteLine("Ingrese un número");
            var numero = Console.ReadLine();
            for (int i = 1; i < int.Parse(numero); i++)
            {
                suma = suma + i;
            }
            Console.WriteLine("La suma total de los enteror anteriores es: " + suma);
            Console.ReadKey();
        }

        public static void maximoComunDivisor()
        {
            Console.WriteLine("Ingrese dos números");
            var numero1 = Console.ReadLine();
            var numero2 = Console.ReadLine();
            int number1;
            int number2;

            bool result1 = int.TryParse(numero1, out number1);
            bool result2 = int.TryParse(numero2, out number2);
            int resultado = 0;

            if (result1 && result2)
            {
                int max = Math.Max(number1, number2);
                int min = Math.Min(number1, number2);
                do
                {
                    resultado = min;
                    min = max % min;
                    max = resultado;
                } while (min != 0);
                Console.WriteLine("El resultado es " + resultado);
            }
            else
            {
                Console.WriteLine("Ingresaste un caracter");
            }
            Console.ReadKey();
        }

        public static void calcularPromedio()
        {
            string numero;
            float suma = 0;
            int contador = 0; ;
            do
            {
                Console.WriteLine("Ingrese un número (con 0 deja de ingresar)");
                numero = Console.ReadLine();
                if (float.Parse(numero) != 0)
                {
                    contador++;
                    suma += float.Parse(numero);
                }
            } while (int.Parse(numero) != 0);
            Console.WriteLine("El resultado es " + (suma / contador));
            Console.ReadKey();
        }
    }//CIERRA LA CLASE
}//CIERRA EL NAMESPACE