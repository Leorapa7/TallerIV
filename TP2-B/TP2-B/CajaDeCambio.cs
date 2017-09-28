using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_B
{
    public class CajaDeCambio : InterfaceTipoDeCC
    {
        public tipoCajaCambio tipo { get; }
        public int cantidadCambios { get; }

        public CajaDeCambio(tipoCajaCambio tipo, int cantidadCambios)
        {
            this.tipo = tipo;
            this.cantidadCambios = cantidadCambios;
        }
    }
}

