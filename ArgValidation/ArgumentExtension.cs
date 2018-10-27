//using System;
//using System.Collections.Generic;
//
//namespace ArgValidation
//{
//    public static class ArgumentExtension
//    {
//        public static T NotNull<T>(this T arg) where T : Argument<T>
//        {
//            return arg;
//        }
//        
//        public static ArgumentEnumerable<T> CountMoreThan<T>(this ArgumentEnumerable<T> arg, int lentght)
//        {
//            return arg;
//        }
//        
//        public static IEnumerable<T> Count1<T>(this IEnumerable<T> arg, int lentght)
//        {
//            return arg;
//        }
//        
//        public static Argument<string> Length(this Argument<string> arg, int length) 
//        {
//            return arg;
//        }
//    }
//}