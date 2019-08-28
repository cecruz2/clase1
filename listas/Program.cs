using System;
using System.Collections.Generic;

namespace listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> dato = new List<int>();
            var diassemana = new List<string>();
            dato.Add(1);
            dato.Add(3);
            dato.Add(4);
            dato.Add(5);
            dato.Add(6);
            dato.Add(7);
            Console.WriteLine("lista de numeros");
            foreach (var item in dato)
            {
                Console.WriteLine(item);
            }
            diassemana.Add("lunes");
            diassemana.Add("martes");
            diassemana.Add("miercoles");
            diassemana.Add("jueves");
            Console.WriteLine("lista de dias");
            foreach (var item in diassemana)
            {
                Console.WriteLine(item);

            }
            //para borrara
            Console.WriteLine("elimina el numero 5");
            dato.Remove(5);
            foreach (var item in dato)
            {
                Console.WriteLine(item);
            }
        }
    }
}
