using System;
using System.Linq.Expressions;
using ArgValidation.Validators;
using System.Collections.Generic;
using ArgValidation.Internal;

namespace ArgValidation
{
    public static class Arg
    {
        #region ObjectValidator
        
        public static ObjectValidator<T> Default<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).Default();
        }
        
        public static ObjectValidator<T> Default<T>(T value, string argName)
        {
            return ValidatorFactory.CreateObjectValidator(value, argName).Default();
        }

        
        public static ObjectValidator<T> NotDefault<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotDefault();
        }
        
        public static ObjectValidator<T> NotDefault<T>(T value, string argName)
        {
            return ValidatorFactory.CreateObjectValidator(value, argName).NotDefault();
        }
        
        public static ObjectValidator<T> Null<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).Null();
        }
        
        public static ObjectValidator<T> Null<T>(T value, string argName)
        {
            return ValidatorFactory.CreateObjectValidator(value, argName).Null();
        }
        
        public static ObjectValidator<T> NotNull<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotNull();
        }
        
        public static ObjectValidator<T> NotNull<T>(T value, string argName)
        {
            return ValidatorFactory.CreateObjectValidator(value, argName).NotNull();
        }
        
        #endregion

        #region StringValidator

        public static StringValidator NullOrEmpty(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrEmpty();
        }
        
        public static StringValidator NullOrEmpty(string value, string argName)
        {
            return ValidatorFactory.CreateStringValidator(value, argName).NullOrEmpty();
        }
        
        public static StringValidator NotNullOrEmpty(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrEmpty();
        }
        
        public static StringValidator NotNullOrEmpty(string value, string argName)
        {
            return ValidatorFactory.CreateStringValidator(value, argName).NotNullOrEmpty();
        }
        
        public static StringValidator NullOrWhitespace(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrWhitespace();
        }
        
        public static StringValidator NullOrWhitespace(string value, string argName)
        {
            return ValidatorFactory.CreateStringValidator(value, argName).NullOrWhitespace();
        }
        
        public static StringValidator NotNullOrWhitespace(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrWhitespace();
        }
        
        public static StringValidator NotNullOrWhitespace(string value, string argName)
        {
            return ValidatorFactory.CreateStringValidator(value, argName).NotNullOrWhitespace();
        }

        #endregion

        #region ComparableValidator

        public static ComparableValidator<int> Positive(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<int> Positive(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Positive();
        }
        
        public static ComparableValidator<decimal> Positive(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<decimal> Positive(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Positive();
        }
        
        public static ComparableValidator<double> Positive(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<double> Positive(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Positive();
        }
        
        public static ComparableValidator<float> Positive(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<float> Positive(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Positive();
        }

        
        
        public static ComparableValidator<int> PositiveOrZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<int> PositiveOrZero(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).PositiveOrZero();
        }
        
        public static ComparableValidator<decimal> PositiveOrZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<decimal> PositiveOrZero(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).PositiveOrZero();
        }
        
        public static ComparableValidator<double> PositiveOrZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<double> PositiveOrZero(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).PositiveOrZero();
        }
        
        public static ComparableValidator<float> PositiveOrZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<float> PositiveOrZero(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).PositiveOrZero();
        }
        
        
        
        public static ComparableValidator<int> Negative(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<int> Negative(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Negative();
        }
        
        public static ComparableValidator<decimal> Negative(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<decimal> Negative(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Negative();
        }
        
        public static ComparableValidator<double> Negative(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<double> Negative(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Negative();
        }
        
        public static ComparableValidator<float> Negative(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<float> Negative(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Negative();
        }
        
        
        
        
        public static ComparableValidator<int> NegativeOrZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<int> NegativeOrZero(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NegativeOrZero();
        }
        
        public static ComparableValidator<decimal> NegativeOrZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<decimal> NegativeOrZero(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NegativeOrZero();
        }
        
        public static ComparableValidator<double> NegativeOrZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<double> NegativeOrZero(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NegativeOrZero();
        }
        
        public static ComparableValidator<float> NegativeOrZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<float> NegativeOrZero(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NegativeOrZero();
        }
        
        
        
        public static ComparableValidator<int> Zero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<int> Zero(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Zero();
        }
        
        public static ComparableValidator<decimal> Zero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<decimal> Zero(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Zero();
        }
        
        public static ComparableValidator<double> Zero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<double> Zero(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Zero();
        }
        
        public static ComparableValidator<float> Zero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<float> Zero(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).Zero();
        }
        
        
        
        public static ComparableValidator<int> NotZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<int> NotZero(int value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NotZero();
        }
        
        public static ComparableValidator<decimal> NotZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<decimal> NotZero(decimal value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NotZero();
        }
        
        public static ComparableValidator<double> NotZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<double> NotZero(double value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NotZero();
        }
        
        public static ComparableValidator<float> NotZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<float> NotZero(float value, string argName)
        {
            return ValidatorFactory.CreateComparableValidator(value, argName).NotZero();
        }

        #endregion

        #region Validate Methods

        public static ComparableValidator<T> Validate<T>(Expression<Func<T>> value) where T : IComparable<T>
        {
            return ValidatorFactory.CreateComparableValidator(value);
        }
        
        public static ComparableValidator<T> Validate<T>(T value, string argName) where T : IComparable<T>
        {
            return ValidatorFactory.CreateComparableValidator(value, argName);
        }
        
        public static StringValidator Validate(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value);
        }
        
        public static StringValidator Validate(string value, string argName)
        {
            return ValidatorFactory.CreateStringValidator(value, argName);
        }
        
        public static EnumerableValidator<T> Validate<T>(Expression<Func<IEnumerable<T>>> value)
        {
            return ValidatorFactory.CreateEnumerableValidator(value);
        }
        
        public static EnumerableValidator<T> Validate<T>(IEnumerable<T> value, string argName)
        {
            return ValidatorFactory.CreateEnumerableValidator(value, argName);
        }

        #endregion
    }
}