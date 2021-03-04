using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisherYates
{
    class Program
    {
        static Random rnd = new Random();


        static void Shuffle<T>(T[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                // NextDouble returns a random number between 0 and 1.
                // ... It is equivalent to Math.random() in Java.
                int j = i + (int)(rnd.NextDouble() * (n - i));
                T t = array[j];
                array[j] = array[i];
                array[i] = t;
            }
        }

        static void Main()
        {
            
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Shuffle(array);
                foreach (int value in array)
                {
                    Console.WriteLine(value);
                    
                }
            Console.ReadLine();



        }
    }
}
