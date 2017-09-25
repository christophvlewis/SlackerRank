using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace ConsoleApp1
{
    public class Program
    {	
		
        static void Main(string[] args)
        {
            bool success;
            Console.WriteLine("Hello World!!");
            string readin = Console.ReadLine();
            PrintOut(ref readin, out success);
            Console.WriteLine(success);
            Console.ReadLine();

        }

        public static void PrintOut(ref string readin, out bool success)
        {
            if(readin != "no")
            {
                Console.WriteLine(readin);
                success = true;
            }
            else
            {
                success = false;
            }

        }
    }

}
