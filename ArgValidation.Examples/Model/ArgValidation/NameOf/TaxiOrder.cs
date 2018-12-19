using System.Linq;

namespace ArgValidation.Examples.Model.ArgValidation.NameOf
{
    class TaxiOrder
    {
        private Car _car;

        // if passanger count is unknown then null
        private int? _passangerCount;

        private string _driverShortName;

        public TaxiOrder(Car car, int? passangerCount, string driverShortName)
        {
            Arg.NotNull(car, nameof(car));
            Arg.IfNotNull(passangerCount, nameof(passangerCount))
                .Positive();

            Arg.Validate(driverShortName, nameof(driverShortName))
                .NotNullOrWhitespace()
                .MaxLength(30)
                .FailedIf(driverShortName.Last() != '.', "Lastname must be shorted. Last char must be '.'");

            _car = car;
            _passangerCount = passangerCount;
            _driverShortName = driverShortName;
        }
    }
}
