using System;

namespace ArgValidation.Examples.Model.ArgValidation.NameOf
{
    class Car
    {
        public CarModel Model { get; }
        public string Color { get; }
        public int ReleaseYear { get; }
        public DateTime DateOfPurchase { get; }
            
        public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
        {
            Arg.NotNull(model, nameof(model));
            Arg.NotDefault(dateOfPurchase, nameof(dateOfPurchase));
            Arg.Positive(releaseYear, nameof(releaseYear));
            
            Arg.Validate(color, nameof(color))
                .NotNullOrWhitespace()
                .LengthLessOrEqualThan(20);
            
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
}