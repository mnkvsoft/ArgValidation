using System;
using BenchmarkDotNet.Attributes;

namespace ArgValidation.Tests.Performance.MethodTests
{
    [CoreJob]
    [MemoryDiagnoser]
    public class ComplexTest
    {
        private static readonly object ObjValue = new object();
        private static readonly int IntValue = 1;
        private static readonly decimal DecimalValue = 1;
        private static readonly StringComparison EnumValue = StringComparison.CurrentCulture;
        private static readonly string StringValue = "value";
        private static readonly int[] ArrayValue = { 1, 2, 3, 4 };


        [Benchmark]
        public void Native()
        {
            // objects validation
            if (ObjValue == null)
                throw new Exception();

            // digits validation
            if (IntValue < 1)
                throw new Exception();
            if (DecimalValue < 0)
                throw new Exception();

            // enum validation
            if (!System.Enum.IsDefined(typeof(StringComparison), EnumValue))
                throw new Exception();

            // string validation
            if(string.IsNullOrWhiteSpace(StringValue))
                throw new Exception();

            // array validation
            if(ArrayValue == null || ArrayValue.Length == 0)
                throw new Exception();
        }

        [Benchmark]
        public void ArgValidation()
        {
            // objects validation
            Arg.Validate(ObjValue, nameof(ObjValue)).NotNull();
            Arg.Validate(IntValue, nameof(IntValue)).NotDefault();

            // digits validation
            Arg.Validate(IntValue, nameof(IntValue)).Positive();
            Arg.Validate(DecimalValue, nameof(DecimalValue)).PositiveOrZero();

            // enum validation
            Arg.Validate(EnumValue, nameof(EnumValue)).DefinedInEnum();

            // string validation
            Arg.Validate(StringValue, nameof(StringValue)).NotNullOrWhitespace();

            // array validation
            Arg.Validate(ArrayValue, nameof(ArrayValue)).NotNullOrEmpty();
        }

        [Benchmark]
        public void ArgValidation_Simple()
        {
            // objects validation
            Arg.NotNull(ObjValue, nameof(ObjValue));
            Arg.NotDefault(IntValue, nameof(IntValue));

            // digits validation
            Arg.Positive(IntValue, nameof(IntValue));
            Arg.PositiveOrZero(DecimalValue, nameof(DecimalValue));

            // enum validation
            //Arg.DefinedInEnum(EnumValue, nameof(EnumValue));

            // string validation
            Arg.NotNullOrWhitespace(StringValue, nameof(StringValue));

            // array validation
            Arg.NotNullOrEmpty(ArrayValue, nameof(ArrayValue));
        }
    }
}
