using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilidadUnica.Interfaces.Imprimir
{
    public interface iImprimir
    {
        void ImprimirTexto(string Texto);
        void ImprimirTexto(string Texto, bool IsLowerCase);
        void ImprimirTexto(string Texto, bool IsUpperCase, ConsoleColor Color);
        
    }
}
