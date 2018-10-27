//using System;
//using System.Collections.Generic;
//using System.Linq.Expressions;
//using ArgValidation.Validators;
//
//namespace ArgValidation.Internal
//{
//    internal static class ValidatorFactory
//    {
//        public static ObjectValidator<T> Arg.Validate<T>(Expression<Func<T>> value)
//        {
//            var argument = Argument<T>.FromExpression(value);
//            var validator = new ObjectValidator<T>(argument);
//            return validator;
//        }
//
//        public static ObjectValidator<T> Arg.Validate<T>(T value, string argName)
//        {
//            return new ObjectValidator<T>(new Argument<T>(value, argName));
//        }
//        
//        public static ComparableValidator<T> CreateComparableValidator<T>(Expression<Func<T>> value) where T : IComparable<T>
//        {
//            var argument = Argument<T>.FromExpression(value);
//            var validator = new ComparableValidator<T>(argument);
//            return validator;
//        }
//        
//        public static ComparableValidator<T> CreateComparableValidator<T>(T value, string argName) where T : IComparable<T>
//        {
//            return new ComparableValidator<T>(new Argument<T>(value, argName));
//        }
//        
//        public static EnumerableValidator<T> CreateEnumerableValidator<T>(Expression<Func<IEnumerable<T>>> value)
//        {
//            var argument = Argument<IEnumerable<T>>.FromExpression(value);
//            var validator = new EnumerableValidator<T>(argument);
//            return validator;
//        }
//        
//        public static EnumerableValidator<T> CreateEnumerableValidator<T>(IEnumerable<T> value, string argName)
//        {
//            return new EnumerableValidator<T>(new Argument<IEnumerable<T>>(value, argName));
//        }
//        
//        public static StringValidator Arg.Validate(Expression<Func<string>> value)
//        {
//            var argument = Argument<string>.FromExpression(value);
//            var validator = new StringValidator(argument);
//            return validator;
//        }
//        
//        public static StringValidator Arg.Validate(string value, string argName)
//        {
//            return new StringValidator (new Argument<string>(value, argName));
//        }
//    }
//}