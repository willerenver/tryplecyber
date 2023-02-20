using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ATMemulator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //se omitieron 50, 25, 10, 5, 1 , ya que estos ningun cajero en el pais los
            //dispensa el monto minimo de retiro es de 100 pesos dominicano
            int[] billet = { 2000, 1000, 500, 200, 100 };
            int[] billetMoney = { 50, 25, 10, 5, 1 };
            int[] Qtybillet = new int[billet.Length];
            int[] QtyMoney = new int[billetMoney.Length];

            Console.WriteLine("Ingrese el monto que desea retirar:");
            decimal amount;

            if (!decimal.TryParse(Console.ReadLine(), out amount) || amount % 1 != 0)
            {

                Console.WriteLine("el monto solicitado no puede ser dispensado, debe tratar con un monto mayor o igual a 100 en multiplo de 100");
            }
            decimal amountrest = amount;


            for (int i = 0; i < billet.Length; i++)
            {
                if (billet[i] != 0)
                {
                    Qtybillet[i] = (int)(amountrest / billet[i]);
                    amountrest -= Qtybillet[i] * billet[i];
                }
            }

            for (int i = 0; i < billetMoney.Length; i++)
            {
                if (billetMoney[i] != 0)
                {

                    QtyMoney[i] = (int)(amountrest / billetMoney[i]);
                    amountrest -= QtyMoney[i] * billetMoney[i];
                }
            }

            Console.WriteLine("Cantidad de billetes:");

            for (int i = 0; i < billet.Length; i++)
            {
                if (Qtybillet[i] > 0)
                {
                    Console.WriteLine("{0} X RD$ {1}", Qtybillet[i], billet[i]);
                }
            }
            Console.WriteLine("Cantidad de monedas:");
            for (int i = 0; i < billetMoney.Length; i++)
            {
                if (QtyMoney[i] > 0)
                {
                    Console.WriteLine("{0} X RD$ {1}", QtyMoney[i], billetMoney[i]);
                }
            }

            Console.ReadKey();

        }
    }
}
