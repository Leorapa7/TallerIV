using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo circulito = new Circulo();
            circulito.radio = 5;
            Console.WriteLine(circulito.calcularArea());
            Console.WriteLine(circulito.calcularPerimetro());

            Cuadrado cuadradito = new Cuadrado();
            cuadradito.lado1 = 2;
            cuadradito.lado2 = 2;
            Console.WriteLine(cuadradito.calcularArea());
            Console.WriteLine(cuadradito.calcularPerimetro());
 
            Triangulo trianguilito = new Triangulo();
            trianguilito.lado1 = 2;
            trianguilito.lado2 = 2;
            trianguilito.lado3 = 2;
            trianguilito.altura = 3;
            Console.WriteLine(trianguilito.calcularArea());
            Console.WriteLine(trianguilito.calcularPerimetro());
            Console.ReadKey();
        }
    }
}
