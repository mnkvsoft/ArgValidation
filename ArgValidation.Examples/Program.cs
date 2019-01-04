using System;
using ArgValidation.Examples.Model.ArgValidation.NameOf;

namespace ArgValidation.Examples
{
    internal class Program
    {
        private static void Main()
        {
            var vwGolf = new CarModel(CarBrand.Volkswagen, "Golf", Weight.Kg(1200));

            var golfCar = new Car(
                model: vwGolf,
                color: "White",
                releaseYear: 2005,
                dateOfPurchase: new DateTime(2008, 02, 12));

            var taxiOrder = new TaxiOrder(golfCar, passangerCount: 2, driverShortName: "Frank M.");

            Console.ReadLine();
        }
    }
}