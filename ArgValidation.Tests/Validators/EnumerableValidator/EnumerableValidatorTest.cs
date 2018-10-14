using ArgValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace ArgValidation.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        private static EnumerableValidator<T> CreateEnumerableValidator<T>(Expression<Func<IEnumerable<T>>> arg)
        {
            var Argument = Argument<IEnumerable<T>>.FromExpression(arg);
            return new EnumerableValidator<T>(Argument);
        }

        //[Fact]
        //public void test()
        //{
        //    int count = 10000000;
        //    Stopwatch s0 = Stopwatch.StartNew();
        //    for (int i = 0; i < count; i++)
        //    {
        //        var exc = ReflectionObjectCreator.Create<ArgumentException>("Its exc mes");
        //    }
        //    s0.Stop();

        //    Stopwatch s1 = Stopwatch.StartNew();
        //    for (int i = 0; i < count; i++)
        //    {
        //        var exc = ReflectionObjectCreator.CreateСache<ArgumentException>("Its exc mes");
        //    }
        //    s1.Stop();

        //    Stopwatch s2 = Stopwatch.StartNew();
        //    for (int i = 0; i < count; i++)
        //    {
        //        var exc = new ArgumentException("Its exc mes");
        //    }
        //    s2.Stop();

        //    Stopwatch s3 = Stopwatch.StartNew();
        //    for (int i = 0; i < count; i++)
        //    {
        //        Activator.CreateInstance(typeof(ArgumentException), "Its exc mes");
        //    }
        //    s3.Stop();

        //    Debug.WriteLine($"s0 = {s0.ElapsedMilliseconds}");
        //    Debug.WriteLine($"s1 = {s1.ElapsedMilliseconds}; d0 = {s0.ElapsedMilliseconds - s1.ElapsedMilliseconds}");
        //    Debug.WriteLine($"s2 = {s2.ElapsedMilliseconds}; d0 = {s0.ElapsedMilliseconds - s2.ElapsedMilliseconds}; d1 = {s1.ElapsedMilliseconds - s2.ElapsedMilliseconds}");
        //    Debug.WriteLine($"s3 = {s3.ElapsedMilliseconds}; d0 = {s0.ElapsedMilliseconds - s3.ElapsedMilliseconds}");
        //}
    }
}
