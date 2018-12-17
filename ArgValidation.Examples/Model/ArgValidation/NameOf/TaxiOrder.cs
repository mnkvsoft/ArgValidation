namespace ArgValidation.Examples.Model.ArgValidation.NameOf
{
    class TaxiOrder
    {
        private Car _car;

        // if passanger count is unknown then null
        private int? _passangerCount;

        public TaxiOrder(Car car, int? passangerCount)
        {
            Arg.NotNull(car, nameof(car));
            Arg.IfNotNull(passangerCount, nameof(passangerCount))
                .Positive();

            _car = car;
            _passangerCount = passangerCount;
        }
    }
}
