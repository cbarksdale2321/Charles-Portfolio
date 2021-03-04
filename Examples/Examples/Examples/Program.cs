using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Oone();
            On();
            On2();



            // O(1) example
             void Oone()
            {
                for (int i = 0; i <
                    5; i++)
                {
                    Console.WriteLine("This is 0(1)");
                    
                }


            }
            // O(n) example
            void On()
            {
                int order = 0;
                int[] numbers = { 1, 2, 3, 4, 5 };

                foreach (int number in numbers)
                {

                    Console.WriteLine($"This is array element {order++} in O(n): " + $"{number}");
                }

            }
            // O(n^2) example
             void On2()
            {
                
                

              
                int[] arr1 = { 3, 4, 6, 8, 9 };

                foreach (int arrys1 in arr1)
                {
                    int[] arr2 = { 3, 4, 6, 8, 9 };

                    foreach (int arrys2 in arr2)
                    {
                        int sum = arrys1 + arrys2;
                        Console.WriteLine($"This is array2 element in O(n^2) added to corresponding array1: " + $"{sum}");

                    }
                    

                    
                }


            }
            Console.ReadLine();

        }
        
    }
}
