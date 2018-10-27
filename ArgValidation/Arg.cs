using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static class Arg
    {
        public static Argument<T> Validate<T>(T argValue, string argName)
        {
            return new Argument<T>(argValue, argName);
        }
        
        public static Argument<T> Validate<T>(Expression<Func<T>> value)
        {
            return ArgumentFactory.FromExpression(value);
        }
        
        
        
        # region object
        
        public static T Default<T>(Expression<Func<T>> value)
        {
            return Validate(value).Default().Value;
        }
        
        public static T Default<T>(T value, string argName)
        {
            return Validate(value, argName).Default().Value;
        }

        
        public static T NotDefault<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotDefault().Value;
        }
        
        public static T NotDefault<T>(T value, string argName)
        {
            return Validate(value, argName).NotDefault().Value;
        }
        
        public static T Null<T>(Expression<Func<T>> value)
        {
            return Validate(value).Null().Value;
        }
        
        public static T Null<T>(T value, string argName)
        {
            return Validate(value, argName).Null().Value;
        }
        
        public static T NotNull<T>(Expression<Func<T>> value)
        {
            return Validate(value).NotNull().Value;
        }
        
        public static T NotNull<T>(T value, string argName)
        {
            return Validate(value, argName).NotNull().Value;
        }
        
        #endregion

        #region string

        public static string NullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NullOrEmpty().Value;
        }
        
        public static string NullOrEmpty(string value, string argName)
        {
            return Validate(value, argName).NullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrEmpty().Value;
        }
        
        public static string NotNullOrEmpty(string value, string argName)
        {
            return Validate(value, argName).NotNullOrEmpty().Value;
        }
        
        public static string NullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NullOrWhitespace().Value;
        }
        
        public static string NullOrWhitespace(string value, string argName)
        {
            return Validate(value, argName).NullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(Expression<Func<string>> value)
        {
            return Validate(value).NotNullOrWhitespace().Value;
        }
        
        public static string NotNullOrWhitespace(string value, string argName)
        {
            return Validate(value, argName).NotNullOrWhitespace().Value;
        }

        #endregion

        #region ComparableValidator

        public static int Positive(Expression<Func<int>> value)
        {
            return Validate(value).Positive().Value;
        }
        
        public static int Positive(int value, string argName)
        {
            return Validate(value, argName).Positive().Value;
        }
        
        public static decimal Positive(Expression<Func<decimal>> value)
        {
            return Validate(value).Positive().Value;
        }
        
        public static decimal Positive(decimal value, string argName)
        {
            return Validate(value, argName).Positive().Value;
        }
        
        public static double Positive(Expression<Func<double>> value)
        {
            return Validate(value).Positive().Value;
        }
        
        public static double Positive(double value, string argName)
        {
            return Validate(value, argName).Positive().Value;
        }
        
        public static float Positive(Expression<Func<float>> value)
        {
            return Validate(value).Positive().Value;
        }
        
        public static float Positive(float value, string argName)
        {
            return Validate(value, argName).Positive().Value;
        }

        
        
        public static int PositiveOrZero(Expression<Func<int>> value)
        {
            return Validate(value).PositiveOrZero().Value;
        }
        
        public static int PositiveOrZero(int value, string argName)
        {
            return Validate(value, argName).PositiveOrZero().Value;
        }
        
        public static decimal PositiveOrZero(Expression<Func<decimal>> value)
        {
            return Validate(value).PositiveOrZero().Value;
        }
        
        public static decimal PositiveOrZero(decimal value, string argName)
        {
            return Validate(value, argName).PositiveOrZero().Value;
        }
        
        public static double PositiveOrZero(Expression<Func<double>> value)
        {
            return Validate(value).PositiveOrZero().Value;
        }
        
        public static double PositiveOrZero(double value, string argName)
        {
            return Validate(value, argName).PositiveOrZero().Value;
        }
        
        public static float PositiveOrZero(Expression<Func<float>> value)
        {
            return Validate(value).PositiveOrZero().Value;
        }
        
        public static float PositiveOrZero(float value, string argName)
        {
            return Validate(value, argName).PositiveOrZero().Value;
        }
        
        
        
        public static int Negative(Expression<Func<int>> value)
        {
            return Validate(value).Negative().Value;
        }
        
        public static int Negative(int value, string argName)
        {
            return Validate(value, argName).Negative().Value;
        }
        
        public static decimal Negative(Expression<Func<decimal>> value)
        {
            return Validate(value).Negative().Value;
        }
        
        public static decimal Negative(decimal value, string argName)
        {
            return Validate(value, argName).Negative().Value;
        }
        
        public static double Negative(Expression<Func<double>> value)
        {
            return Validate(value).Negative().Value;
        }
        
        public static double Negative(double value, string argName)
        {
            return Validate(value, argName).Negative().Value;
        }
        
        public static float Negative(Expression<Func<float>> value)
        {
            return Validate(value).Negative().Value;
        }
        
        public static float Negative(float value, string argName)
        {
            return Validate(value, argName).Negative().Value;
        }
        
        
        
        
        public static int NegativeOrZero(Expression<Func<int>> value)
        {
            return Validate(value).NegativeOrZero().Value;
        }
        
        public static int NegativeOrZero(int value, string argName)
        {
            return Validate(value, argName).NegativeOrZero().Value;
        }
        
        public static decimal NegativeOrZero(Expression<Func<decimal>> value)
        {
            return Validate(value).NegativeOrZero().Value;
        }
        
        public static decimal NegativeOrZero(decimal value, string argName)
        {
            return Validate(value, argName).NegativeOrZero().Value;
        }
        
        public static double NegativeOrZero(Expression<Func<double>> value)
        {
            return Validate(value).NegativeOrZero().Value;
        }
        
        public static double NegativeOrZero(double value, string argName)
        {
            return Validate(value, argName).NegativeOrZero().Value;
        }
        
        public static float NegativeOrZero(Expression<Func<float>> value)
        {
            return Validate(value).NegativeOrZero().Value;
        }
        
        public static float NegativeOrZero(float value, string argName)
        {
            return Validate(value, argName).NegativeOrZero().Value;
        }
        
        
        
        public static int Zero(Expression<Func<int>> value)
        {
            return Validate(value).Zero().Value;
        }
        
        public static int Zero(int value, string argName)
        {
            return Validate(value, argName).Zero().Value;
        }
        
        public static decimal Zero(Expression<Func<decimal>> value)
        {
            return Validate(value).Zero().Value;
        }
        
        public static decimal Zero(decimal value, string argName)
        {
            return Validate(value, argName).Zero().Value;
        }
        
        public static double Zero(Expression<Func<double>> value)
        {
            return Validate(value).Zero().Value;
        }
        
        public static double Zero(double value, string argName)
        {
            return Validate(value, argName).Zero().Value;
        }
        
        public static float Zero(Expression<Func<float>> value)
        {
            return Validate(value).Zero().Value;
        }
        
        public static float Zero(float value, string argName)
        {
            return Validate(value, argName).Zero().Value;
        }
        
        
        
        public static int NotZero(Expression<Func<int>> value)
        {
            return Validate(value).NotZero().Value;
        }
        
        public static int NotZero(int value, string argName)
        {
            return Validate(value, argName).NotZero().Value;
        }
        
        public static decimal NotZero(Expression<Func<decimal>> value)
        {
            return Validate(value).NotZero().Value;
        }
        
        public static decimal NotZero(decimal value, string argName)
        {
            return Validate(value, argName).NotZero().Value;
        }
        
        public static double NotZero(Expression<Func<double>> value)
        {
            return Validate(value).NotZero().Value;
        }
        
        public static double NotZero(double value, string argName)
        {
            return Validate(value, argName).NotZero().Value;
        }
        
        public static float NotZero(Expression<Func<float>> value)
        {
            return Validate(value).NotZero().Value;
        }
        
        public static float NotZero(float value, string argName)
        {
            return Validate(value, argName).NotZero().Value;
        }

        #endregion
    }
}