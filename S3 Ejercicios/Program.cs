using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEMANA_3_15_08
{
    class Program
    {
        static void Main(string[] args)
        {   //Array 10 valores
            int i = 0;
            int suma = 0;
            int[] numbers = new int[10];
            for (i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Digite el número {i}");
                numbers[i] = Int32.Parse(Console.ReadLine());
                suma += numbers[i];
            }
            //Promedio de los 10 valores
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"El promedio de los números es {suma / numbers.Length}");
            Console.WriteLine("----------------------------------");

            //Diccionario
            Dictionary<String, String> NombreEdad = new Dictionary<string, String>();

            NombreEdad.Add("Mauricio Avalos", "40");
            NombreEdad.Add("Griselda Avalos", "42");
            NombreEdad.Add("Gabriela Avalos", "24");
            NombreEdad.Add("Juan Avalos", "65");

            foreach (KeyValuePair<String, String> edad in NombreEdad)
            {
                Console.WriteLine("clave: {0}, valor: {1}", edad.Key, edad.Value);
            }

            Console.ReadKey();

        }
    }
}
