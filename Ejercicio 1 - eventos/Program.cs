using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el codigo de vehiculo");
            int codigo = int.Parse(Console.ReadLine());
            while (codigo!=0)
            {
                Console.WriteLine("ingrese la marca de vehiculo");
                string marca =(Console.ReadLine());
                Console.WriteLine("ingrese el modelo de vehiculo");
                string modelo = (Console.ReadLine());
                Console.WriteLine("ingrese la patente de vehiculo");
                string patente = (Console.ReadLine());

            }

        }
    }
}
