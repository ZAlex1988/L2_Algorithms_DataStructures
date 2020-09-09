using System;
using System.Collections.Generic;

namespace L2_Algorithms_DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array examples
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/single-dimensional-arrays

            int[] ExampleArray = new int[5];
            ExampleArray[0] = 0;
            ExampleArray[1] = 1;

            Console.WriteLine(ExampleArray[0]);
            Console.WriteLine(ExampleArray[1]);
            Console.WriteLine(ExampleArray[2]); // what to expect here?

            //Alternate forms of initialization
            string[] weekDays1 = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
            string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            // Exercise: print the element with content "Thu"
            Console.WriteLine(weekDays2[4]);

            // multi-diemnsional arrays
            // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/multidimensional-arrays

            int[,] Array2D = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

            // What will this print? --> will print 8
            Console.WriteLine(Array2D[3, 1]);

            // Exercise: Create a 2D array of strings - 4 rows and 3 columns
            // each row to contain related colors (e.g. "red", "orange", "brown")
            string[,] stringsArray2D = new string[4, 3] { { "red", "orange", "brown" }, { "green", "blue", "purple" }, { "yellow", "red", "orange" }, { "black", "white", "orange" } };


            // Exercise: Print each row
            for (int i = 0; i <= stringsArray2D.GetUpperBound(0); i++)
            {
                string row = "";
                for (int j = 0; j <= stringsArray2D.GetUpperBound(1); j++)
                {
                    if (row.Length != 0)
                    {
                        row += ", ";
                    }
                    row += stringsArray2D[i, j];
                }
                Console.WriteLine(row);
            }


            // Hash tables/ Dictionaries
            // https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=netframework-4.8
            // May need to add Using System.Collections.Generic

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // Add some key value pairs to the dictionary
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            // Why do get an error below? ---> throws error because dictionary already contains key rtf
            //openWith.Add("rtf", "word.exe");

            // How can we fix the error? --> check if dictionary contains the key first and then either overwrite the key or add new one
            if (openWith.ContainsKey("rtf"))
            {
                openWith["rtf"] = "word.exe";
            } else
            {
                openWith.Add("rtf", "word.exe");
            }


            
            // The key is used to index values 
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
             
            // The values associated with a key can be changed
            openWith["rtf"] = "winword.exe";
            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            // Delete item at key
            openWith.Remove("doc");
        }
    }
}
