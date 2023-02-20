using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valuerandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int qty = getQty();
            List<int> randomnumbers = RandomNumbers.generateRandomNumbers(qty, 1, 101);
            getRandomNumbers(randomnumbers);
            Console.ReadKey();
        }

        //obtenemos el valor valido introudccido
        public static int getQty()
        {
            int qty;
            //preguntamos al usuario primero la cantidad que desea generar
            Console.WriteLine("Ingrese la cantidad de numeros aleatorios que desea generar (maximo de 20):");

            //usamos este while para verificar que la cantidad introduccida es correcta.
            while (!int.TryParse(Console.ReadLine(), out qty) || qty < 1 || qty > 20)
            {
                if (qty == 0)
                {
                    qty = 5; //numero por defecto
                    break;
                }

                Console.WriteLine("debe ingresar una cantidad entre 1 y 20.");


            }
            //si llegamos aqui retornamos el valor qty=cantidad
            return qty;
        }

        //muestra el resultado de la lista ingresada
        public static void getRandomNumbers(List<int> randomNumbers)
        {

            Console.WriteLine("Numeros Aleatorios generados:");
            foreach (int number in randomNumbers)
            {

                Console.WriteLine(number + " ");
            }
        }
    }
}
