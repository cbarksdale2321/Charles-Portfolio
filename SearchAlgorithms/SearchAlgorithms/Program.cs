using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //linear
            int[] arr = { 1, 2, 3, 4, 5 };
            int search_element = 5;
            search(arr, search_element);
            Console.ReadLine();
            
            //binary
            int[] arr2 = { 2, 3, 4, 10, 40 };
            int n = arr.Length;
            int x = 10;
            int result = binarySearch(arr2, 0, n - 1, x);
            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at index "
                                  + result);
            Console.ReadLine();

            //interpolation

            int[] arr3 = new int[]{ 10, 12, 13, 16, 18,
                           19, 20, 21, 22, 23,
                           24, 33, 35, 42, 47 };

            // Element to be searched                       
            x = 18;
            n = arr.Length;
            int index = interpolationSearch(arr3, 0, n - 1, x);

            // If element was found
            if (index != -1)
                Console.WriteLine("Element found at index " +
                                   index);
            else
                Console.WriteLine("Element not found.");
        }

        public static void search(int[] arr,
                             int search_Element)
        {
            int left = 0;
            int length = arr.Length;
            int right = length - 1;
            int position = -1;

            // run loop from 0 to right
            for (left = 0; left <= right;)
            {
                if (arr[left] == search_Element)
                {
                    position = left;
                    Console.WriteLine(
                        "Element found in Array at "
                        + (position + 1) + " Position with "
                        + (left + 1) + " Attempt");
                    break;
                }
                if (arr[right] == search_Element)
                {
                    position = right;
                    Console.WriteLine(
                        "Element found in Array at "
                        + (position + 1) + " Position with "
                        + (length - right) + " Attempt");
                    break;
                }

                left++;
                right--;
            }

            // if element not found
            if (position == -1)
                Console.WriteLine("Not found in Array with "
                                   + left + " Attempt");
        }
        static int binarySearch(int[] arr, int l,
                           int r, int x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (arr[mid] == x)
                    return mid;
                if (arr[mid] > x)
                    return binarySearch(arr, l, mid - 1, x);

                return binarySearch(arr, mid + 1, r, x);
            }
            return -1;
        }
        static int interpolationSearch(int[] arr, int lo,
                               int hi, int x)
        {
            int pos;

            if (lo <= hi && x >= arr[lo] &&
                            x <= arr[hi])
            {

                pos = lo + (((hi - lo) /
                        (arr[hi] - arr[lo])) *
                              (x - arr[lo]));

                if (arr[pos] == x)
                    return pos;

                if (arr[pos] < x)
                    return interpolationSearch(arr, pos + 1,
                                               hi, x);
                if (arr[pos] > x)
                    return interpolationSearch(arr, lo,
                                               pos - 1, x);
            }
            return -1;
        }

    }
}
