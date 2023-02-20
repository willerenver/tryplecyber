using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Debe ingresar la cantidad de numero primo a generar por defecto esta el numero 9:");
            //validamos si el input introduccido es un numero si no enviamos el 9 por defecto
            int qty;
            if (!int.TryParse(Console.ReadLine(), out qty))
            {
                qty = 9;
            }
            //obtenemos el resultado introduccio por el usuario y lo almacenamos en un list
            List<int> numbers = PrimerNumbers.generatePrimeNumbers(qty);
            Console.WriteLine("los numeros primos son:");
            foreach (int number in numbers) Console.WriteLine(number);

            Console.ReadKey();
        }





    }
}
