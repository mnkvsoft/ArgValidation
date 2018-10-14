using System;
using ArgValidation.Examples.Model.ArgValidation.NameOf;

namespace ArgValidation.Examples
{
    internal class Program
    {
        private static void Main()
        {
            var vwGolf = new CarModel();

            var myVaz2101 = new Car(
                vwGolf,
                "White",
                2005,
                new DateTime(2008, 02, 12));

            Console.WriteLine(myVaz2101);
            Console.ReadLine();
        }
    }
}