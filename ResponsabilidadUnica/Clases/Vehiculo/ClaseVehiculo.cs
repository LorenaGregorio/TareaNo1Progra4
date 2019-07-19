using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ResponsabilidadUnica.Interfaces.Vehiculo;

namespace ResponsabilidadUnica.Clases.Vehiculo
{
    public class ClaseVehiculo : InterVehiculo
    {


        //imprimir
        private void ImprimirConsola(string texto)
        {
            
            Console.WriteLine(texto);


        }


        //interfaces

        

        public void AcelerarVehiculo(string Texto1)
        {
            ImprimirConsola(Texto1);
        }

        public void FrenarVehiculo(string Texto1, string texto2)
        {
            ImprimirConsola(Texto1 + " " + texto2);
        }

        public void DesacelerarVehiculo(string Texto1, string texto2, string texto3)
        {

            ImprimirConsola(Texto1 + " " + texto2 + " " + texto3);
        }

        public void EncenderVehiculo(string Texto1, string texto2, string texto3, string texto4)
        {
            ImprimirConsola(Texto1 + " " + texto2 + " " + texto3 + " " + texto4);
        }

        public void ApagarVehiculo(string Texto1, string texto2, string texto3, string texto4, string texto5)
        {
            ImprimirConsola(Texto1 + " " + texto2 + " " + texto3 + " " + texto4 + " " + texto5);
        }

        public void AcerelarVehiculo(string Texto1)
        {
           
        }
    }
}
