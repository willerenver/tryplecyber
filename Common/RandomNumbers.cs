using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class RandomNumbers
    {
        public static List<int> generateRandomNumbers(int qty, int firstRandom, int LastRandom)
        {

            //instanciamos la clase Random esta nos permitira generar un aletario entre el rango dado
            Random rnd = new Random();
            //usamos el hashset porque este nos permite verificar que no haya reptido dentro del mismo
            HashSet<int> randomNumbers = new HashSet<int>();
            //este while se ejecutar mintra la cantidad de randomNumbers sea menor a qty
            while (randomNumbers.Count < qty)
            {
               
                randomNumbers.Add(rnd.Next(firstRandom, LastRandom));
            }
            //retornamos el randomNumbers
            return new List<int>(randomNumbers);
        }
    }
}
