using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        // todo: implement for all numeric types

        #region Positive

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
        public static int Positive(Expression<Func<int>> value)
        {
            return Validate(value).Positive().Value;
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
        public static int Positive(int argValue, string argName)
        {
            return Validate(argValue, argName).Positive().Value;
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
        public static long Positive(Expression<Func<long>> value)
        {
            return Validate(value).Positive().Value;
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
        public static long Positive(long argValue, string argName)
        {
            return Validate(argValue, argName).Positive().Value;
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
        public static decimal Positive(Expression<Func<decimal>> value)
        {
            return Validate(value).Positive().Value;
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
        public static decimal Positive(decimal argValue, string argName)
        {
            return Validate(argValue, argName).Positive().Value;
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
        public static double Positive(Expression<Func<double>> value)
        {
            return Validate(value).Positive().Value;
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
        public static double Positive(double argValue, string argName)
        {
            return Validate(argValue, argName).Positive().Value;
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
        public static float Positive(Expression<Func<float>> value)
        {
            return Validate(value).Positive().Value;
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
        public static float Positive(float argValue, string argName)
        {
            return Validate(argValue, argName).Positive().Value;
        }

        #endregion

        #region PositiveOrZero

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
        public static int PositiveOrZero(Expression<Func<int>> value)
        {
            return Validate(value).PositiveOrZero().Value;
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
        public static int PositiveOrZero(int argValue, string argName)
        {
            return Validate(argValue, argName).PositiveOrZero().Value;
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
        public static long PositiveOrZero(Expression<Func<long>> value)
        {
            return Validate(value).PositiveOrZero().Value;
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
        public static long PositiveOrZero(long argValue, string argName)
        {
            return Validate(argValue, argName).PositiveOrZero().Value;
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
        public static decimal PositiveOrZero(Expression<Func<decimal>> value)
        {
            return Validate(value).PositiveOrZero().Value;
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
        public static decimal PositiveOrZero(decimal argValue, string argName)
        {
            return Validate(argValue, argName).PositiveOrZero().Value;
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
        public static double PositiveOrZero(Expression<Func<double>> value)
        {
            return Validate(value).PositiveOrZero().Value;
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
        public static double PositiveOrZero(double argValue, string argName)
        {
            return Validate(argValue, argName).PositiveOrZero().Value;
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
        public static float PositiveOrZero(Expression<Func<float>> value)
        {
            return Validate(value).PositiveOrZero().Value;
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
        public static float PositiveOrZero(float argValue, string argName)
        {
            return Validate(argValue, argName).PositiveOrZero().Value;
        }

        #endregion

        #region Negative

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
        public static int Negative(Expression<Func<int>> value)
        {
            return Validate(value).Negative().Value;
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
        public static int Negative(int argValue, string argName)
        {
            return Validate(argValue, argName).Negative().Value;
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
        public static long Negative(Expression<Func<long>> value)
        {
            return Validate(value).Negative().Value;
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
        public static long Negative(long argValue, string argName)
        {
            return Validate(argValue, argName).Negative().Value;
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
        public static decimal Negative(Expression<Func<decimal>> value)
        {
            return Validate(value).Negative().Value;
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
        public static decimal Negative(decimal argValue, string argName)
        {
            return Validate(argValue, argName).Negative().Value;
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
        public static double Negative(Expression<Func<double>> value)
        {
            return Validate(value).Negative().Value;
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
        public static double Negative(double argValue, string argName)
        {
            return Validate(argValue, argName).Negative().Value;
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
        public static float Negative(Expression<Func<float>> value)
        {
            return Validate(value).Negative().Value;
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
        public static float Negative(float argValue, string argName)
        {
            return Validate(argValue, argName).Negative().Value;
        }

        #endregion

        #region NegativeOrZero

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
        public static int NegativeOrZero(Expression<Func<int>> value)
        {
            return Validate(value).NegativeOrZero().Value;
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
        public static int NegativeOrZero(int argValue, string argName)
        {
            return Validate(argValue, argName).NegativeOrZero().Value;
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
        public static long NegativeOrZero(Expression<Func<long>> value)
        {
            return Validate(value).NegativeOrZero().Value;
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
        public static long NegativeOrZero(long argValue, string argName)
        {
            return Validate(argValue, argName).NegativeOrZero().Value;
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
        public static decimal NegativeOrZero(Expression<Func<decimal>> value)
        {
            return Validate(value).NegativeOrZero().Value;
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
        public static decimal NegativeOrZero(decimal argValue, string argName)
        {
            return Validate(argValue, argName).NegativeOrZero().Value;
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
        public static double NegativeOrZero(Expression<Func<double>> value)
        {
            return Validate(value).NegativeOrZero().Value;
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
        public static double NegativeOrZero(double argValue, string argName)
        {
            return Validate(argValue, argName).NegativeOrZero().Value;
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
        public static float NegativeOrZero(Expression<Func<float>> value)
        {
            return Validate(value).NegativeOrZero().Value;
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
        public static float NegativeOrZero(float argValue, string argName)
        {
            return Validate(argValue, argName).NegativeOrZero().Value;
        }

        #endregion

        #region Zero

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
        public static int Zero(Expression<Func<int>> value)
        {
            return Validate(value).Zero().Value;
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
        public static int Zero(int argValue, string argName)
        {
            return Validate(argValue, argName).Zero().Value;
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
        public static long Zero(Expression<Func<long>> value)
        {
            return Validate(value).Zero().Value;
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
        public static long Zero(long argValue, string argName)
        {
            return Validate(argValue, argName).Zero().Value;
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
        public static decimal Zero(Expression<Func<decimal>> value)
        {
            return Validate(value).Zero().Value;
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
        public static decimal Zero(decimal argValue, string argName)
        {
            return Validate(argValue, argName).Zero().Value;
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
        public static double Zero(Expression<Func<double>> value)
        {
            return Validate(value).Zero().Value;
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
        public static double Zero(double argValue, string argName)
        {
            return Validate(argValue, argName).Zero().Value;
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
        public static float Zero(Expression<Func<float>> value)
        {
            return Validate(value).Zero().Value;
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
        public static float Zero(float argValue, string argName)
        {
            return Validate(argValue, argName).Zero().Value;
        }

        #endregion

        #region NotZero

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
        public static int NotZero(Expression<Func<int>> value)
        {
            return Validate(value).NotZero().Value;
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
        public static int NotZero(int argValue, string argName)
        {
            return Validate(argValue, argName).NotZero().Value;
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
        public static long NotZero(Expression<Func<long>> value)
        {
            return Validate(value).NotZero().Value;
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
        public static long NotZero(long argValue, string argName)
        {
            return Validate(argValue, argName).NotZero().Value;
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
        public static decimal NotZero(Expression<Func<decimal>> value)
        {
            return Validate(value).NotZero().Value;
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
        public static decimal NotZero(decimal argValue, string argName)
        {
            return Validate(argValue, argName).NotZero().Value;
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
        public static double NotZero(Expression<Func<double>> value)
        {
            return Validate(value).NotZero().Value;
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
        public static double NotZero(double argValue, string argName)
        {
            return Validate(argValue, argName).NotZero().Value;
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
        public static float NotZero(Expression<Func<float>> value)
        {
            return Validate(value).NotZero().Value;
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
        public static float NotZero(float argValue, string argName)
        {
            return Validate(argValue, argName).NotZero().Value;
        }

        #endregion
    }
}