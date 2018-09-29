using System;

namespace ArgValidation.Examples
{
    class Program
    {
        enum CarBrand
        {
            MercedesBenz,
            Audi,
            Bmw,
            Kia,
            Hyundai,
            Honda,
            Gaz,
            Vaz,
            Belaz
        }

        struct Weight : IComparable<Weight>
        {
            private double _kg;

            public Weight(double kg)
            {
                _kg = kg;
            }

            public static Weight Kg(double kg)
            {
                Arg.Validate(() => kg).MoreOrEqualThan(0);
                
                return new Weight(kg);
            }
            
            public static Weight Tn(double tn)
            {
                return new Weight(kg: tn * 1000);
            }

            public int CompareTo(Weight other)
            {
                return _kg.CompareTo(other._kg);
            }

            public override string ToString()
            {
                return _kg < 1000 ? _kg + " Kg" : _kg / 1000 + " Tn";
            }
        }
        
        class CarModel
        {
            public CarBrand Brand { get; }
            public string Model { get; }
            public Weight Weight { get; }
            
            public CarModel(CarBrand brand, string model, Weight weight)
            {
                Arg.Validate(() => model)
                    .LengthLessThan(30);
                
                Arg.Validate(() => weight)
                    .LessOrEqualThan(Weight.Tn(1000)); // БелАЗ-75710 - 810 tons
                
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public override string ToString()
            {
                return $"{Brand} {Model}";
            }
        }        
        
        class Car
        {
            public CarModel Model { get; }
            public string Color { get; }
            public int ReleaseYear { get; }
            public DateTime DateOfPurchase { get; }
            
            public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
            {
                Arg.NotNull(() => model);
                Arg.NotDefault(() => dateOfPurchase);
                
                Arg.Validate(() => color)
                    .NotNullOrWhitespace()
                    .LengthLessOrEqualThan(20);

                Arg.Validate(() => releaseYear)
                    .MoreThan(0);
                
                Model = model;
                Color = color;
                ReleaseYear = releaseYear;
                DateOfPurchase = dateOfPurchase;
            }

            public override string ToString()
            {
                return $"{nameof(Model)}: {Model}, {nameof(ReleaseYear)}: {ReleaseYear}, {nameof(Color)}: {Color}";
            }
        }
        
        static void Main(string[] args)
        {
//            CarModel vaz2101 = new CarModel(
//                CarBrand.Vaz, 
//                "ВАЗ-2101",
//                Weight.Kg(955));
//            
//            Car myVaz2101 = new Car(
//                model:vaz2101,
//                color: "Cherry",
//                releaseYear: 1975,
//                dateOfPurchase: new DateTime(1975, 07, 02));
            
            CarModel vaz2101 = new CarModel(
                CarBrand.Vaz, 
                "ВАЗ-2101",
                Weight.Kg(955));
            
            Car myVaz2101 = new Car(
                model:vaz2101,
                color: "C",
                releaseYear: 19,
                dateOfPurchase: new DateTime());
        }
    }
}