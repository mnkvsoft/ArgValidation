using System;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for number types
    /// </summary>
    public static class ArgumentDigitExtension
    {
        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than 0</exception>
        public static Argument<int> Positive(this Argument<int> arg)
        {
            return arg.MoreThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than 0</exception>
        public static Argument<long> Positive(this Argument<long> arg)
        {
            return arg.MoreThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than 0</exception>
        public static Argument<decimal> Positive(this Argument<decimal> arg)
        {
            return arg.MoreThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than 0</exception>
        public static Argument<double> Positive(this Argument<double> arg)
        {
            return arg.MoreThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is not more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is not more than 0</exception>
        public static Argument<float> Positive(this Argument<float> arg)
        {
            return arg.MoreThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than 0</exception>
        public static Argument<int> PositiveOrZero(this Argument<int> arg)
        {
            return arg.Min(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than 0</exception>
        public static Argument<long> PositiveOrZero(this Argument<long> arg)
        {
            return arg.Min(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than 0</exception>
        public static Argument<decimal> PositiveOrZero(this Argument<decimal> arg)
        {
            return arg.Min(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than 0</exception>
        public static Argument<double> PositiveOrZero(this Argument<double> arg)
        {
            return arg.Min(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is less than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is less than 0</exception>
        public static Argument<float> PositiveOrZero(this Argument<float> arg)
        {
            return arg.Min(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than or equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than or equals 0</exception>
        public static Argument<int> Negative(this Argument<int> arg)
        {
            return arg.LessThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than or equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than or equals 0</exception>
        public static Argument<long> Negative(this Argument<long> arg)
        {
            return arg.LessThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than or equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than or equals 0</exception>
        public static Argument<decimal> Negative(this Argument<decimal> arg)
        {
            return arg.LessThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than or equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than or equals 0</exception>
        public static Argument<double> Negative(this Argument<double> arg)
        {
            return arg.LessThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than or equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than or equals 0</exception>
        public static Argument<float> Negative(this Argument<float> arg)
        {
            return arg.LessThan(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than 0</exception>
        public static Argument<int> NegativeOrZero(this Argument<int> arg)
        {
            return arg.Max(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than 0</exception>
        public static Argument<long> NegativeOrZero(this Argument<long> arg)
        {
            return arg.Max(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than 0</exception>
        public static Argument<decimal> NegativeOrZero(this Argument<decimal> arg)
        {
            return arg.Max(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than 0</exception>
        public static Argument<double> NegativeOrZero(this Argument<double> arg)
        {
            return arg.Max(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentOutOfRangeException"/> if argument is more than 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Throws if argument is more than 0</exception>
        public static Argument<float> NegativeOrZero(this Argument<float> arg)
        {
            return arg.Max(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<byte> Zero(this Argument<byte> arg)
        {
            return arg.Equal((byte)0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<int> Zero(this Argument<int> arg)
        {
            return arg.Equal(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<long> Zero(this Argument<long> arg)
        {
            return arg.Equal(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<decimal> Zero(this Argument<decimal> arg)
        {
            return arg.Equal(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<double> Zero(this Argument<double> arg)
        {
            return arg.Equal(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is not equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is not equals 0</exception>
        public static Argument<float> Zero(this Argument<float> arg)
        {
            return arg.Equal(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<byte> NotZero(this Argument<byte> arg)
        {
            return arg.NotEqual((byte)0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<int> NotZero(this Argument<int> arg)
        {
            return arg.NotEqual(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<long> NotZero(this Argument<long> arg)
        {
            return arg.NotEqual(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<decimal> NotZero(this Argument<decimal> arg)
        {
            return arg.NotEqual(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<double> NotZero(this Argument<double> arg)
        {
            return arg.NotEqual(0);
        }

        /// <summary>
        /// <para>
        /// Throws <see cref="ArgumentException"/> if argument is equals 0
        /// </para>
        /// <para>
        /// Note. For validation <see cref="Nullable{T}"/> you must first call the methods 
        /// <see cref="ArgumentConditionExtension.IfNotNull{T}(ArgValidation.Argument{System.Nullable{T}})"/> or <see cref="Arg.IfNotNull{T}(System.Nullable{T},string)"/>
        /// </para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if argument is equals 0</exception>
        public static Argument<float> NotZero(this Argument<float> arg)
        {
            return arg.NotEqual(0);
        }
    }
}