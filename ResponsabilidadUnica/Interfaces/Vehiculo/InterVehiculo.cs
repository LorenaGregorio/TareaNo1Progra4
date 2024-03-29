﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsabilidadUnica.Interfaces.Vehiculo
{
    interface InterVehiculo
    {
        //Acelerar texto1
        void AcelerarVehiculo(string Texto1);
        //Frenar Texto2
        void FrenarVehiculo(string Texto1,string texto2);
        //DESACELERAR Texto3
        void DesacelerarVehiculo(string Texto1, string texto2,string texto3);
        //ENCENDER Texto4
        void EncenderVehiculo(string Texto1, string texto2, string texto3,string texto4);
        //APAGAR Texto5
        void ApagarVehiculo(string Texto1, string texto2, string texto3,string texto4,string texto5);
    }
}
