using System;
using System.Collections.Generic;
using System.Text;

namespace clase1
{
    class Automovil
    {
        #region propiedades
        public string Tipo_vehiculo { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public string Identificador { get; set; }
        #endregion
        #region constructores
        public Automovil(string marca)
        {
            Marca = marca;    
        }
        public Automovil(string color ,string marca)
        {
            Color = color;
            Marca = marca;
        }
        public Automovil(string tipo_vehiculo ,string marca ,string color ,string identificador)
        {
            Tipo_vehiculo = tipo_vehiculo;
            Color = color;
            Marca = marca;
            Identificador = identificador;           

        }
        public Automovil()
        {
                
        }
        #endregion
        #region metodos
        public void IngresarVehiculo()
        {
            //var msg = "si";
            //while (msg=="si")
            //{
            //    Automovil nuevo = new Automovil();
                Console.WriteLine("dijite el tipo de vehiculo");
                Tipo_vehiculo = Console.ReadLine();
                Console.WriteLine("digite el color del veiculo");
                Color = Console.ReadLine();
                Console.WriteLine("digite la marca del vehiculo");
                Marca = Console.ReadLine();
                Console.WriteLine("digite el identificador del automovil");
                Identificador = Console.ReadLine();
                //Console.WriteLine("desea agregar ");
                                             
            //}
            


        }
        public void mostrar()
        {
            Console.WriteLine($"el tipo de veiculo es:{Tipo_vehiculo} ");
            Console.WriteLine($"el color del vehiculo es: {Color}");
            Console.WriteLine($"la marca del vehiculo es: {Marca}");
            Console.WriteLine($"el identificador de la es {Identificador}");
        }
        public void modifica(string marca)
        {
            Marca = marca;
        }


        #endregion
    }
}
