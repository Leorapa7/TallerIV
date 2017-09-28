using System;
using System.Collections.Generic;
using System.Text;

namespace TP2_B
{
    public enum tipoCajaCambio
    {
        manual = 0,
        automatica = 1,
    }

    public interface InterfaceTipoDeCC
    {
        tipoCajaCambio tipo { get; }
        int cantidadCambios { get; }
    }
}