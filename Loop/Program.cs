using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            for (int iterator = 0; iterator < 3; iterator++)
            {
                Console.WriteLine("Outer Loop :" + iterator);

                for (int _iterator = 0; _iterator < 2; ++_iterator)
                {
                    Console.WriteLine("Inner Loop : " + iterator);
                }
            }

            string[] brandTV = { "LG", "SONY", "SAMSUNG", "TCL", "JVC" };

            foreach (string television in brandTV)
            {
                Console.WriteLine("Brand" + television);
            }
        }
    }
}





