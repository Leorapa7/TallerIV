using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Promedio
    {
        static public float _PromedioDeMateria(Materias m) {

            var promedio = m.notas_materia.Sum(n => n.notas) / m.notas_materia.Count;

            return promedio;
        }
    }
}
