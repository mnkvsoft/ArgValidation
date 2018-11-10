using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
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
    }
}