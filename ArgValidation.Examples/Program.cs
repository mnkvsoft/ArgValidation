using System;
using ArgValidation.Examples.Model;
using ArgValidation.Examples.Model.ArgValidation.ExpressionTree;
using Dawn;

namespace ArgValidation.Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            CarModel vwGolf = new CarModel();
            
            Car myVaz2101 = new Car(
                model:vwGolf,
                color: "White",
                releaseYear: 2005,
                dateOfPurchase: new DateTime(2008, 02, 12));
            
            Console.WriteLine(myVaz2101);
            Console.ReadLine();
        }
    }
}