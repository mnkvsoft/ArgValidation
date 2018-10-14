using System;

namespace ArgValidation.Examples.Model.Native
{
    class Car
    {
        public CarModel Model { get; }
        public string Color { get; }
        public int ReleaseYear { get; }
        public DateTime DateOfPurchase { get; }
            
        public Car(CarModel model, string color, int releaseYear, DateTime dateOfPurchase)
        {
            if(model == null)
                throw new ArgumentNullException(nameof(model));
            
            if(dateOfPurchase == default)
                throw new ArgumentException($"Argument '{nameof(dateOfPurchase)}' must be not default value");
            
            if(releaseYear < 1)
                throw new ArgumentException($"Argument '{nameof(releaseYear)}' must be more than 0. Current value: '{releaseYear}'");
                
            if(string.IsNullOrWhiteSpace(color))
                throw new ArgumentException($"Argument '{nameof(color)}' cannot be empty or whitespace. Current value: {color}");
            
            if(color.Length > 20)
                throw new ArgumentException($"Argument '{nameof(color)}' must be length less or equals than 20. Current length: {color.Length}");
            
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