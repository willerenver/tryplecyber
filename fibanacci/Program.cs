using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibanacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Ingrese la cantidad de elementos (máximo 20): ");
            int qty = 5;
            int.TryParse(Console.ReadLine(), out qty);

            if (qty < 1 || qty > 20)
            {
                qty = 5;
            }

            List<int> Randomnumbers = RandomNumbers.generateRandomNumbers(qty, 1, 101);
            Console.WriteLine("Numeros aleatorios generados:");
            foreach (int numbers in Randomnumbers)
            {
                Console.Write(numbers + " ");
            }
            List<int> NumbersPrime = PrimerNumbers.generatePrimeNumbers(Randomnumbers);
            Console.WriteLine("\n\nNumeros primos encontrados:");
            foreach (int numbers in NumbersPrime)
            {
                Console.Write(numbers + " ");
            }


            Console.WriteLine("\n\n");
            Console.WriteLine("Tomado el mayor valor del conjunto de coincidencias entre números primos y aleatorios:");

            var combined = Randomnumbers.Intersect(NumbersPrime);
            int MaxValue = combined.Max();

            Console.WriteLine(MaxValue);

            int num, num1 = 0, num2 = 1;

            List<int> fibonacci = new List<int>();

            for (int i = 0; i < MaxValue; i++)
            {
                if (i <= 1)
                {
                    num = i;
                }
                else
                {
                    num = num1 + num2;
                    num1 = num2;
                    num2 = num;
                }
                fibonacci.Add(num);
            }
            foreach (int number in fibonacci)
            {
                Console.Write(number + " ");
            }

            Console.ReadKey();
        }



    }
}
