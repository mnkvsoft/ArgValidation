using System;
using System.Diagnostics;
using Xunit;

namespace Mynkovv.Validating.Tests.Validators.EnumerableValidator
{
    public partial class EnumerableValidatorTest
    {
        [Fact]
        public void CountEqual_ValuesIsNull_InvalidOperationException()
        {
            object[] nullValue = null;
            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() => CreateEnumerableValidator(() => nullValue).CountEqual(0));
            Assert.Equal($"Object with name '{nameof(nullValue)}' is null. Сannot get count elements from null object", exc.Message);
        }

        [Fact]
        public void CountEqual_CountEqual_Ok()
        {
            object[] objs = new[] { new object(), new object() };
            int expectedCount = objs.Length;
            CreateEnumerableValidator(() => objs).CountEqual(expectedCount);
        }

        [Fact]
        public void CountEqual_CountNotEqual_ArgumentException()
        {
            object[] objs = new[] { new object(), new object() };
            int expectedCount = objs.Length + 1;
            ArgumentException exc = Assert.Throws<ArgumentException>(() => CreateEnumerableValidator(() => objs).CountEqual(expectedCount));
            Assert.Equal($"Object with name '{nameof(objs)}' must contains {expectedCount} elements. Current count elements: {objs.Length}", exc.Message);
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
