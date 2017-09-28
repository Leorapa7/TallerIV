using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Triangulo : Figuras_Areas.Figuras
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public double lado3 { get; set; }
        public double altura { get; set; }
        public override double calcularArea()
        {
            double area = (lado1 * altura) / 2;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimtro = lado1 + lado2 + lado3;
            return perimtro;
        }
    }
}
