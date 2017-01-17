using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BinarySearch
{
    class BinarySearch
    {

        private int[] data; // array of values
        private static Random generator = new Random();

        // Create an array of given size fill with random integers
        // Binary Search constructor
        public BinarySearch(int size) 
        {
            data = new int[size]; // allocate space for array

            
            for (int i=0; i<size; i++) 
            {
                data[i] = generator.Next(10, 100);
            }
            Array.Sort(data);
        }

        // perform a binary search on array
        public int BinarySearch1(int searchElement)
        {
            int low = 0; // 0 is always going to be the first element
            int high = data.Length - 1; // Find highest element
            int middle = (low + high + 1) / 2; // Find middle element
            int location = -1; // Return value -1 if not found

            do 
            {
                
                Console.Write(RemainingElements(low, high));

                
                for (int i = 0; i < middle; i++)
                    Console.Write("   ");

                Console.WriteLine(" * "); 

                // if element is found at middle
                if (searchElement == data[middle])
                    location = middle; // location is current middle

                // middle element is too high
                else if (searchElement < data[middle])
                    high = middle - 1; // eliminate lower half
                else // middle element is too low
                    low = middle + 1; // eleminate lower half

                middle = (low + high + 1) / 2; // recalculate the middle  
            } while ((low <= high) && (location == -1));

            return location; // return location of search key
        }

        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;
             
            // output spaces for alignment
            for (int i = 0; i < low; i++)
                temporary += "    ";

            // output elements left in array 
            for (int i = low; i <= high; i++)
                temporary += data[i] + " ";

            temporary += "\n";
            return temporary;
        }

        // Method to output values in array
        public override string ToString()
        {
            return RemainingElements(0, data.Length - 1);
        }
    }




}
