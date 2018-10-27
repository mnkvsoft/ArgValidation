using ArgValidation.Validators;

namespace ArgValidation
{
    public static class ComparableValidatorExtension
    {
        public static Argument<int> Positive(this Argument<int> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static Argument<decimal> Positive(this Argument<decimal> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static Argument<double> Positive(this Argument<double> validator)
        {
            return validator.MoreThan(0);
        }
        
        public static Argument<float> Positive(this Argument<float> validator)
        {
            return validator.MoreThan(0);
        }
        
        
        
        public static Argument<int> PositiveOrZero(this Argument<int> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static Argument<decimal> PositiveOrZero(this Argument<decimal> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static Argument<double> PositiveOrZero(this Argument<double> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        public static Argument<float> PositiveOrZero(this Argument<float> validator)
        {
            return validator.MoreOrEqualThan(0);
        }
        
        
        
        public static Argument<int> Negative(this Argument<int> validator)
        {
            return validator.LessThan(0);
        }
        
        public static Argument<decimal> Negative(this Argument<decimal> validator)
        {
            return validator.LessThan(0);
        }
        
        public static Argument<double> Negative(this Argument<double> validator)
        {
            return validator.LessThan(0);
        }
        
        public static Argument<float> Negative(this Argument<float> validator)
        {
            return validator.LessThan(0);
        }
        
        
        
        public static Argument<int> NegativeOrZero(this Argument<int> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static Argument<decimal> NegativeOrZero(this Argument<decimal> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static Argument<double> NegativeOrZero(this Argument<double> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        public static Argument<float> NegativeOrZero(this Argument<float> validator)
        {
            return validator.LessOrEqualThan(0);
        }
        
        
        
        public static Argument<int> Zero(this Argument<int> validator)
        {
            return validator.Equal(0);
        }
        
        public static Argument<decimal> Zero(this Argument<decimal> validator)
        {
            return validator.Equal(0);
        }
        
        public static Argument<double> Zero(this Argument<double> validator)
        {
            return validator.Equal(0);
        }
        
        public static Argument<float> Zero(this Argument<float> validator)
        {
            return validator.Equal(0);
        }
        
        
        
        public static Argument<int> NotZero(this Argument<int> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static Argument<decimal> NotZero(this Argument<decimal> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static Argument<double> NotZero(this Argument<double> validator)
        {
            return validator.NotEqual(0);
        }
        
        public static Argument<float> NotZero(this Argument<float> validator)
        {
            return validator.NotEqual(0);
        }
    }
}