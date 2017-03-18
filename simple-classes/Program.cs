using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            car myNewCar = new car();

            myNewCar.make = "Ford";
            myNewCar.model = "Expedition";
            myNewCar.year = 2004;
            myNewCar.color = "Blue";

            Console.WriteLine("{0} - {1} - {2}",
            myNewCar.make,
            myNewCar.model,
            myNewCar.color);

            //double marketValueOfCar = determineMarketValue(myNewCar);
            Console.WriteLine("Car's value: {0:C}", myNewCar.DetermineMarketValue()); // {0:C} return value with a $ symbol
            Console.ReadLine();

        
        }

        private static double determineMarketValue(car car)
        {
            double carValue = 100.0;

            // may go online some day to lookup car's value
            // and retrieve its value into carValue variable
            return carValue;
        }

    }

    class car
    {
        public string make { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public string color { get; set; }

        public double DetermineMarketValue()
        {
            double carValue = 100.0;

            if (this.year > 1990)
                carValue = 10000.0;
            else
                carValue = 2000.0;

            return carValue;
        }
    }



}
