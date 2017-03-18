using System;
using System.Collections.Generic;

namespace price_code_discount_clean2
{
    internal class Program


    {
        static string priceCode;
        static float iPrice;
        static float priceCodeNum;

        public static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Welcome to Pricer Pro v0.2!\nEnter pricing code as \"quit\" when done");
                GetInput();
                priceCodeNum = PriceCodeSwitch();
                CalcPrice();
            } while (priceCode != "QUIT");
        }

        static void GetInput()
        {
            Console.WriteLine("Enter pricing code: ");
            priceCode = Console.ReadLine().ToUpper().;
            Console.WriteLine("Enter item price: ");
            iPrice = float.Parse(Console.ReadLine());
        }
        static float PriceCodeSwitch()
        {
            switch (priceCode)
            {
                case "H":
                    return 0.5F;
                case "F":
                    return 0.4F;
                case "T":
                    return 0.33F;
                case "Q":
                    return 0.25F;
                default:
                    return 0;
            }
        }

        private static void CalcPrice()
        {
            Console.WriteLine(("Original Price: $" + iPrice + "   Discount: $" + (iPrice * priceCodeNum) +
                               "   New price: $" + (iPrice - (iPrice * priceCodeNum))));
        }
    }
}