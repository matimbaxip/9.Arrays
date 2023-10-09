using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // one way attribute of creating an array
            int[] LuckyNumbers = { 4, 5, 8, 9 };
            Console.WriteLine(LuckyNumbers[0]);
            //If you want to populate it later the 5 is the size
            string[] friends = new string[5];
            friends[0] = "Matimba";
            friends[1] = "John";
            friends[2] = "peter";
            Console.WriteLine(friends[2]);
            Console.ReadLine();

        }
    }
}
