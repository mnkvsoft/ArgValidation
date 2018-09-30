using ArgValidation.Validators;

namespace ArgValidation
{
    public static class ComparableValidatorExtension
    {
        public static ComparableValidator<int> Positive(this ComparableValidator<int> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static ComparableValidator<decimal> Positive(this ComparableValidator<decimal> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static ComparableValidator<double> Positive(this ComparableValidator<double> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static ComparableValidator<float> Positive(this ComparableValidator<float> validator)
        {
            return validator.MoreThan(0);
        }
        
        
        
        public static ComparableValidator<int> PositiveOrZero(this ComparableValidator<int> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static ComparableValidator<decimal> PositiveOrZero(this ComparableValidator<decimal> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static ComparableValidator<double> PositiveOrZero(this ComparableValidator<double> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static ComparableValidator<float> PositiveOrZero(this ComparableValidator<float> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        
        
        public static ComparableValidator<int> Negative(this ComparableValidator<int> validator)
        {
            return validator.LessThan(0);
        }
        
        public static ComparableValidator<decimal> Negative(this ComparableValidator<decimal> validator)
        {
            return validator.LessThan(0);
        }
        
        public static ComparableValidator<double> Negative(this ComparableValidator<double> validator)
        {
            return validator.LessThan(0);
        }
        
        public static ComparableValidator<float> Negative(this ComparableValidator<float> validator)
        {
            return validator.LessThan(0);
        }
        
        
        
        public static ComparableValidator<int> NegativeOrZero(this ComparableValidator<int> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static ComparableValidator<decimal> NegativeOrZero(this ComparableValidator<decimal> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static ComparableValidator<double> NegativeOrZero(this ComparableValidator<double> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static ComparableValidator<float> NegativeOrZero(this ComparableValidator<float> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        
        
        public static ComparableValidator<int> Zero(this ComparableValidator<int> validator)
        {
            return validator.Equal(0);
        }
        
        public static ComparableValidator<decimal> Zero(this ComparableValidator<decimal> validator)
        {
            return validator.Equal(0);
        }
        
        public static ComparableValidator<double> Zero(this ComparableValidator<double> validator)
        {
            return validator.Equal(0);
        }
        
        public static ComparableValidator<float> Zero(this ComparableValidator<float> validator)
        {
            return validator.Equal(0);
        }
        
        
        
        public static ComparableValidator<int> NotZero(this ComparableValidator<int> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static ComparableValidator<decimal> NotZero(this ComparableValidator<decimal> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static ComparableValidator<double> NotZero(this ComparableValidator<double> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static ComparableValidator<float> NotZero(this ComparableValidator<float> validator)
        {
            return validator.NotEqual(0);
        }
    }
}