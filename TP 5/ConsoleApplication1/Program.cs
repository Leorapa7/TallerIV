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
            List<Materias> Materias_Total = new List<Materias>();
            Materias_Total.Add(new Materias("Photoshop", 2015, 1));
            Materias_Total.Add(new Materias("Unity", 2015, 2));
            Materias_Total.Add(new Materias("Base de Datos", 2016, 1));

            _materiasDePrimerCuatrimestre (Materias_Total);
            _materiasOrdenadas (Materias_Total);
            _notasTp (Materias_Total);

            Console.WriteLine("*** Punto 4 ***");
            Console.WriteLine("Promedio: " + Promedio._PromedioDeMateria(Materias_Total[0]).ToString());
            Console.WriteLine("*** ***** ***\n");

            Console.ReadKey();
        }

        static public void _materiasDePrimerCuatrimestre (List<Materias> Materias_Total)
        {
            Console.WriteLine("*** Punto 1 ***");
            var materias = Materias_Total.Where(m => m.cuatrimestre == 1);

            foreach (Materias m in materias)
            {
                Console.WriteLine(m.nombre);
            }
            Console.WriteLine("*** ***** ***\n");
        }
        static public void _materiasOrdenadas (List<Materias> Materias_Total)
        {
            Console.WriteLine("*** Punto 2 ***");
            var materias = Materias_Total.OrderBy(m => m.nombre);

            foreach (Materias m in materias)
            {
                Console.WriteLine(m.nombre);
            }
            Console.WriteLine("*** ***** ***\n");
        }

        static public void _notasTp (List<Materias> Materias_Total)
        {
            Console.WriteLine("*** Punto 3 ***");
            var notas = Materias_Total.SelectMany(m => m.notas_materia.Where(n => n.tipo == "TP")).ToArray ();
            foreach (Notas n in notas)
            {
                Console.WriteLine(n.notas);
            }
            Console.WriteLine("*** ***** ***\n");
        }
    }
}
