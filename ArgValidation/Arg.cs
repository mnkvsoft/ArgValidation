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

        public static ObjectValidator<T> NotDefault<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotDefault();
        }
        
        public static ObjectValidator<T> Null<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).Null();
        }
        
        public static ObjectValidator<T> NotNull<T>(Expression<Func<T>> value)
        {
            return ValidatorFactory.CreateObjectValidator(value).NotNull();
        }
        
        #endregion

        #region StringValidator

        public static StringValidator NullOrEmpty<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrEmpty();
        }
        
        public static StringValidator NotNullOrEmpty<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrEmpty();
        }
        
        public static StringValidator NullOrWhitespace<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NullOrWhitespace();
        }
        
        public static StringValidator NotNullOrWhitespace<T>(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value).NotNullOrWhitespace();
        }

        #endregion

        #region ComparableValidator

        public static ComparableValidator<int> Positive(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<decimal> Positive(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<double> Positive(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }
        
        public static ComparableValidator<float> Positive(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Positive();
        }

        
        
        public static ComparableValidator<int> PositiveOrZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<decimal> PositiveOrZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<double> PositiveOrZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        public static ComparableValidator<float> PositiveOrZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).PositiveOrZero();
        }
        
        
        
        public static ComparableValidator<int> Negative(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<decimal> Negative(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<double> Negative(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        public static ComparableValidator<float> Negative(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Negative();
        }
        
        
        
        public static ComparableValidator<int> NegativeOrZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<decimal> NegativeOrZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<double> NegativeOrZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        public static ComparableValidator<float> NegativeOrZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NegativeOrZero();
        }
        
        
        
        public static ComparableValidator<int> Zero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<decimal> Zero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<double> Zero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        public static ComparableValidator<float> Zero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).Zero();
        }
        
        
        
        public static ComparableValidator<int> NotZero(Expression<Func<int>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<decimal> NotZero(Expression<Func<decimal>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<double> NotZero(Expression<Func<double>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }
        
        public static ComparableValidator<float> NotZero(Expression<Func<float>> value)
        {
            return ValidatorFactory.CreateComparableValidator(value).NotZero();
        }

        #endregion

        #region Validate Methods

        public static ComparableValidator<T> Validate<T>(Expression<Func<T>> value) where T : IComparable<T>
        {
            return ValidatorFactory.CreateComparableValidator(value);
        }
        
        public static StringValidator Validate(Expression<Func<string>> value)
        {
            return ValidatorFactory.CreateStringValidator(value);
        }
        
        public static EnumerableValidator<T> Validate<T>(Expression<Func<IEnumerable<T>>> value)
        {
            return ValidatorFactory.CreateEnumerableValidator(value);
        }

        #endregion
    }
}