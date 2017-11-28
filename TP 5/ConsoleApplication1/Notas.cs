using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Notas
    {
        public string tipo;
        public string fecha;
        public float notas;

        public Notas (string tipo, string fecha, float notas)
        {
            this.tipo = tipo;
            this.fecha = fecha;
            this.notas = notas;
        }

    }
}
