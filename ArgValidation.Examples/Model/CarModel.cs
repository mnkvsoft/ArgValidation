namespace ArgValidation.Examples.Model
{
    public class CarModel
    {
        public CarBrand Brand { get; }
        public string Model { get; }
        public Weight Weight { get; }

        public CarModel(CarBrand brand, string model, Weight weight)
        {
            Arg.Validate(model, nameof(model))
                .NotNullOrWhitespace()
                .MaxLength(30);

            Arg.Validate(weight, nameof(weight))
                .Max(Weight.Tn(1000)); // БелАЗ-75710 - 810 tons

            Brand = brand;
            Model = model;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Brand} {Model}";
        }
    }
}