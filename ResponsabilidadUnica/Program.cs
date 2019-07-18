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

            Console.WriteLine("El auto acelera por:");
            auto.accionVehiculo("Inyeccion");

            Console.WriteLine("\nEl auto frena por:");
            auto.accionVehiculo("Comprension", "Hidraulicos");

            Console.WriteLine("\nEl auto Desacelera por:");
            auto.accionVehiculo("Comprension", "Hidraulicos", "Electricos");

            Console.WriteLine("\nEl auto Enciende por:");
            auto.accionVehiculo("Comprension", "Hidraulicos", "Electricos", "Neumaticos");

            Console.WriteLine("\nEl auto se apaga por:");
            auto.accionVehiculo("Comprension", "Hidraulicos", "Electricos", "Neumaticos", "Ahogamiento");

            Console.ReadKey();
        }
    }
}
