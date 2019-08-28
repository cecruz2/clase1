using System;

namespace clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Automovil auto = new Automovil();
            auto.IngresarVehiculo();
            auto.modifica("trek");
            auto.mostrar();
        }
    }
}
