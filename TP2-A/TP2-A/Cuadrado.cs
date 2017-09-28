using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Cuadrado : Figuras_Areas.Figuras
    {
        public double lado1 { get; set; }
        public double lado2 { get; set; }
        public override double calcularArea()
        {
            double area = lado1 * lado2;
            return area;
        }

        public override double calcularPerimetro()
        {
            double perimtro = lado1 * 2 + lado2 * 2;
            return perimtro;
        }
    }
}
