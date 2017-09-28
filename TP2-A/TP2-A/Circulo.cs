using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Circulo:Figuras_Areas.Figuras
    {
        public double radio { get; set; }
        public override double calcularArea() {
            double area = Math.PI * radio * radio;
            return area;     
        }

        public override double calcularPerimetro()
        {
            double perimtro = 2 * Math.PI * radio;
            return perimtro;
        }
    }
}
