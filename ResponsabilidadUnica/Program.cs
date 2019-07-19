using ResponsabilidadUnica.Clases.Imprimir;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResponsabilidadUnica.Clases.Vehiculo;

//Vehiculos --> ACELERAR, FRENAR, DESACELERAR, ENCENDER, APAGAR


namespace ResponsabilidadUnica
{

    class Program
    {
        static void Main(string[] args)
        {
            //var imprimir = new Imprimir();
            //imprimir.ImprimirTexto("Hola, soy una prueba1");
            //imprimir.ImprimirTexto("Hola, soy una prueba2", true);
            //imprimir.ImprimirTexto("Hola, soy una prueba3", false);
            //imprimir.ImprimirTexto("Hola, soy una prueba4", false, ConsoleColor.Yellow);
            //imprimir.ImprimirTexto("Hola, soy una prueba5", true, ConsoleColor.Blue);

            Console.WriteLine("Vehiculo");
            var auto = new ClaseVehiculo();

            Console.WriteLine("\nEl vehiculo acelera por:");
            auto.AcelerarVehiculo("Inyeccion");

            Console.WriteLine("\nEl vehiculo frena por:");
            auto.FrenarVehiculo("", "Frenos Hidraulicos");

            Console.WriteLine("\nEl vehiculo desacelera por:");
            auto.DesacelerarVehiculo("", "", "Electrico");

            Console.WriteLine("\nEl vehiculo enciende por:");
            auto.EncenderVehiculo("", "", "", "Electrico");

            Console.WriteLine("\nEl vehiculo se apaga por:");
            auto.ApagarVehiculo("", "", "", "", "Ahogamiento");

            Console.ReadKey();
        }
    }
}
