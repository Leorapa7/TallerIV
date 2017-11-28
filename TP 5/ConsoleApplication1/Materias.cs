using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Materias
    {
        public string nombre;
        public int anio;
        public int cuatrimestre;
        public List<Notas> notas_materia = new List<Notas>();
        
        public Materias (string nombre, int anio, int cuatrimestre)
        {
            this.nombre = nombre;
            this.anio = anio;
            this.cuatrimestre = cuatrimestre;
            notas_materia.Add(new Notas("TP", "04-10-2017", 10));
            notas_materia.Add(new Notas("TP", "05-10-2017", 7));
            notas_materia.Add(new Notas("Examen", "06-10-2017", 8));
        }
    }
    
}
