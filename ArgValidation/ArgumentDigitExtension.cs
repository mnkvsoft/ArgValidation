namespace ArgValidation
{
    public static class ArgumentDigitExtension
    {
        public static Argument<int> Positive(this Argument<int> argument)
        {
            return argument.MoreThan(0);
        }
        
        public static Argument<decimal> Positive(this Argument<decimal> argument)
        {
            return argument.MoreThan(0);
        }
        
        public static Argument<double> Positive(this Argument<double> argument)
        {
            return argument.MoreThan(0);
        }
        
        public static Argument<float> Positive(this Argument<float> argument)
        {
            return argument.MoreThan(0);
        }
        
        
        
        public static Argument<int> PositiveOrZero(this Argument<int> argument)
        {
            return argument.MoreOrEqualThan(0);
        }
        
        public static Argument<decimal> PositiveOrZero(this Argument<decimal> argument)
        {
            return argument.MoreOrEqualThan(0);
        }
        
        public static Argument<double> PositiveOrZero(this Argument<double> argument)
        {
            return argument.MoreOrEqualThan(0);
        }
        
        public static Argument<float> PositiveOrZero(this Argument<float> argument)
        {
            return argument.MoreOrEqualThan(0);
        }
        
        
        
        public static Argument<int> Negative(this Argument<int> argument)
        {
            return argument.LessThan(0);
        }
        
        public static Argument<decimal> Negative(this Argument<decimal> argument)
        {
            return argument.LessThan(0);
        }
        
        public static Argument<double> Negative(this Argument<double> argument)
        {
            return argument.LessThan(0);
        }
        
        public static Argument<float> Negative(this Argument<float> argument)
        {
            return argument.LessThan(0);
        }
        
        
        
        public static Argument<int> NegativeOrZero(this Argument<int> argument)
        {
            return argument.LessOrEqualThan(0);
        }
        
        public static Argument<decimal> NegativeOrZero(this Argument<decimal> argument)
        {
            return argument.LessOrEqualThan(0);
        }
        
        public static Argument<double> NegativeOrZero(this Argument<double> argument)
        {
            return argument.LessOrEqualThan(0);
        }
        
        public static Argument<float> NegativeOrZero(this Argument<float> argument)
        {
            return argument.LessOrEqualThan(0);
        }
        
        
        
        public static Argument<int> Zero(this Argument<int> argument)
        {
            return argument.Equal(0);
        }
        
        public static Argument<decimal> Zero(this Argument<decimal> argument)
        {
            return argument.Equal(0);
        }
        
        public static Argument<double> Zero(this Argument<double> argument)
        {
            return argument.Equal(0);
        }
        
        public static Argument<float> Zero(this Argument<float> argument)
        {
            return argument.Equal(0);
        }
        
        
        
        public static Argument<int> NotZero(this Argument<int> argument)
        {
            return argument.NotEqual(0);
        }
        
        public static Argument<decimal> NotZero(this Argument<decimal> argument)
        {
            return argument.NotEqual(0);
        }
        
        public static Argument<double> NotZero(this Argument<double> argument)
        {
            return argument.NotEqual(0);
        }
        
        public static Argument<float> NotZero(this Argument<float> argument)
        {
            return argument.NotEqual(0);
        }
    }
}