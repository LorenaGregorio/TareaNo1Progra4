using ResponsabilidadUnica.Interfaces.Imprimir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilidadUnica.Clases.Imprimir
{
    public class Imprimir : iImprimir
    {
        private void ImprimirArchivoTexto(string Texto)
        {
            //Se abre el archivo
            //Se va a la última línea
            //Se escribe
        }

        private void ImprimirConsola(string Texto)
        {
            Console.WriteLine(Texto);
        }

        private void ImprimirConsola(string Texto, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(Texto);
        }

        private void ImprimirEnImpresora(string Texto)
        {
            //ToDo

            //Detectar marca
            //Detectar driver
            //Formato de recepción (binario, texto)
            //Enviar información
            //Buscar un API o librería que haga el trabajo por mi

            // A P I //
        }

        private void ImprimirPopUp(string Texto)
        {
            //Si es Windows Forms: MessageBox.Show(Texto);

        }

        private void ImprimirPopUp(string Texto, ConsoleColor Color)
        {
            //Si es Windows Forms: MessageBox.Show(Texto, Color);
        }

        public void ImprimirTexto(string Texto)
        {
            ImprimirConsola(Texto);
        }

        //metodo para agrgar mayuscala o minuscula
        public void ImprimirTexto(string Texto, bool IsLowerCase)
        {
            //VALIDADOR TERNARIO: validación if/else a través de signos
            //USAR SIEMPRE ESTE (VALIDAR ANTES SI ES FUNCIONAL)
            //ToLower: imprimir en minúscula
            //ToUpper: imprimir en mayúscula
            ImprimirConsola(IsLowerCase ? Texto.ToLower() : Texto.ToUpper());
        }

        public void ImprimirTexto(string Texto, bool IsUpperCase, ConsoleColor Color)
        {
            Console.ForegroundColor = Color;
            ImprimirConsola(IsUpperCase ? Texto.ToUpper() : Texto.ToLower());
        }
    }
}
