using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashvsArray
{
    class Program
    {
        
        static void Main(string[] args)
        {
             

            hashArray();
            System.Threading.Thread.Sleep(7000);
            Console.Clear();
            stackQueue();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Thats all :)");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();

        }

        public static void hashArray()
        {
            
            string[] states = { "Alabama", "Alaska", "American Samoa", "Arizona", "Arkansas" };
            for (int i = 0; i <= 4; i++)
            {


                Console.WriteLine($"\nThis is an array element of US territory: {states[i]}");




            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Hit any key to continue...", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Now I will display a hashtable using the same data. This method uses keys that give a value to each name.");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nHit any key to continue...", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;

            Console.ReadKey();

            Hashtable hashtable = new Hashtable() {


                { 1, "Alabama" }, {2, "Alaska" }, {3, "American Samoa" } ,{4, "Arizona" },{5, "Arkansas"}



            };
            foreach (var ele2 in hashtable.Keys)
            {
                Console.WriteLine("{0} is the key for {1}", ele2,
                                hashtable[ele2]);
            }

            Console.WriteLine("\nThis allows me to call each element in the hastable using the keys.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Stack vs Queue will begin in 7 seconds...", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;






        }
        public static void stackQueue()
        {
            Stack myStack = new Stack();

            // Inserting the elements into the Stack 
            myStack.Push("Alabama");
            myStack.Push("Alaska");
            myStack.Push("American Samoa");
            myStack.Push("Arizona");
            myStack.Push("Arkansas");

            foreach (var elem in myStack)
            {
                Console.WriteLine(elem);
            }
            // Displaying the count of elements 
            // contained in the Stack 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nAfter setting the elements of the stack I can now determine the amount, the top, \nand the bottom of it. I can now remove and add at will.", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(3000);

            Console.Write("Total number of elements in the Stack are : ");

            Console.WriteLine(myStack.Count);

            // Displaying the top element of Stack 
            // without removing it from the Stack 
            Console.WriteLine("Element at the top is : " + myStack.Pop());

            // Displaying the top element of Stack 
            // without removing it from the Stack 
            Console.WriteLine("Element at the top after removing : " + myStack.Peek());


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNow I will show the same data in a queue. Hit any key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();

            //Queue reference from GeeksforGeeks
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("A queue allows me to pull out any element in it and step through the entirety of the queue.");
            Console.ForegroundColor = ConsoleColor.White;
            System.Threading.Thread.Sleep(3000);

            Queue myQueue = new Queue();

            // Inserting the elements into the Queue 
            myQueue.Enqueue("Alabama");
            myQueue.Enqueue("Alaska");        
            myQueue.Enqueue("American Samoa");
            myQueue.Enqueue("Arizona");
            myQueue.Enqueue("Arkansas");

            // Displaying the count of elements 
            // contained in the Queue 
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);

            foreach (Object obj in myQueue)
            {
                Console.WriteLine(obj);
            }

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Returning is 5 seconds...");
            Console.ForegroundColor = ConsoleColor.White;

            System.Threading.Thread.Sleep(5000);
           
        }
       

        }

    }

