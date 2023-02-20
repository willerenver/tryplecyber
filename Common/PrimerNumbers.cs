using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class PrimerNumbers
    {
        //generamos el listado de numero primos
        public static List<int> generatePrimeNumbers(int number)
        {

            List<int> listprimenumber = new List<int>();
            int counter = 2;
            while (listprimenumber.Count < number)
            {
                if (Validator.IsPrime(counter))
                {
                    listprimenumber.Add(counter);
                }
                counter++;
            }
            return listprimenumber;
        }

        public static List<int> generatePrimeNumbers(List<int> listnumber)
        {

            List<int> listprimenumber = new List<int>();
            foreach (int num in listnumber)
            {
                if (Validator.IsPrime(num))
                {
                    listprimenumber.Add(num);
                }
            }

            return listprimenumber;
        }

    }
}
