namespace ArgValidation
{
    public static class ArgumentDigitExtension
    {
        public static Argument<int> Positive(this Argument<int> arg)
        {
            return arg.MoreThan(0);
        }
        
        public static Argument<decimal> Positive(this Argument<decimal> arg)
        {
            return arg.MoreThan(0);
        }
        
        public static Argument<double> Positive(this Argument<double> arg)
        {
            return arg.MoreThan(0);
        }
        
        public static Argument<float> Positive(this Argument<float> arg)
        {
            return arg.MoreThan(0);
        }
        
        
        
        public static Argument<int> PositiveOrZero(this Argument<int> arg)
        {
            return arg.Min(0);
        }
        
        public static Argument<decimal> PositiveOrZero(this Argument<decimal> arg)
        {
            return arg.Min(0);
        }
        
        public static Argument<double> PositiveOrZero(this Argument<double> arg)
        {
            return arg.Min(0);
        }
        
        public static Argument<float> PositiveOrZero(this Argument<float> arg)
        {
            return arg.Min(0);
        }
        
        
        
        public static Argument<int> Negative(this Argument<int> arg)
        {
            return arg.LessThan(0);
        }
        
        public static Argument<decimal> Negative(this Argument<decimal> arg)
        {
            return arg.LessThan(0);
        }
        
        public static Argument<double> Negative(this Argument<double> arg)
        {
            return arg.LessThan(0);
        }
        
        public static Argument<float> Negative(this Argument<float> arg)
        {
            return arg.LessThan(0);
        }
        
        
        
        public static Argument<int> NegativeOrZero(this Argument<int> arg)
        {
            return arg.Max(0);
        }
        
        public static Argument<decimal> NegativeOrZero(this Argument<decimal> arg)
        {
            return arg.Max(0);
        }
        
        public static Argument<double> NegativeOrZero(this Argument<double> arg)
        {
            return arg.Max(0);
        }
        
        public static Argument<float> NegativeOrZero(this Argument<float> arg)
        {
            return arg.Max(0);
        }
        
        
        
        public static Argument<int> Zero(this Argument<int> arg)
        {
            return arg.Equal(0);
        }
        
        public static Argument<decimal> Zero(this Argument<decimal> arg)
        {
            return arg.Equal(0);
        }
        
        public static Argument<double> Zero(this Argument<double> arg)
        {
            return arg.Equal(0);
        }
        
        public static Argument<float> Zero(this Argument<float> arg)
        {
            return arg.Equal(0);
        }
        
        
        
        public static Argument<int> NotZero(this Argument<int> arg)
        {
            return arg.NotEqual(0);
        }
        
        public static Argument<decimal> NotZero(this Argument<decimal> arg)
        {
            return arg.NotEqual(0);
        }
        
        public static Argument<double> NotZero(this Argument<double> arg)
        {
            return arg.NotEqual(0);
        }
        
        public static Argument<float> NotZero(this Argument<float> arg)
        {
            return arg.NotEqual(0);
        }
    }
}