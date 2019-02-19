using ArgValidation.Tests.Performance.MethodTests.Comparable;
using ArgValidation.Tests.Performance.MethodTests.Condition;
using ArgValidation.Tests.Performance.MethodTests.Digit;
using ArgValidation.Tests.Performance.MethodTests.Enum;
using ArgValidation.Tests.Performance.MethodTests.Enumerable;
using ArgValidation.Tests.Performance.MethodTests.Object;
using ArgValidation.Tests.Performance.MethodTests.String;
using BenchmarkDotNet.Running;

namespace ArgValidation.Tests.Performance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // object
            BenchmarkRunner.Run<DefaultTest>();
            BenchmarkRunner.Run<NotDefaultTest>();
            BenchmarkRunner.Run<NotNullTest>();
            BenchmarkRunner.Run<NullTest>();
            BenchmarkRunner.Run<EqualTest>();
            BenchmarkRunner.Run<NotEqualTest>();
            BenchmarkRunner.Run<InTest>();
            BenchmarkRunner.Run<NotInTest>();
            BenchmarkRunner.Run<FailedIfTest>();

            // string
            BenchmarkRunner.Run<MethodTests.String.NotNullOrEmptyTest>();
            BenchmarkRunner.Run<MethodTests.String.NullOrEmptyTest>();
            BenchmarkRunner.Run<NotNullOrWhitespaceTest>();
            BenchmarkRunner.Run<NullOrWhitespaceTest>();
            BenchmarkRunner.Run<LengthEqualTest>();
            BenchmarkRunner.Run<LengthMoreThanTest>();
            BenchmarkRunner.Run<LengthLessThanTest>();
            BenchmarkRunner.Run<MinLengthTest>();
            BenchmarkRunner.Run<MaxLengthTest>();
            BenchmarkRunner.Run<LengthInRangeTest>();
            BenchmarkRunner.Run<MethodTests.String.ContainsTest>();
            BenchmarkRunner.Run<MethodTests.String.NotContainsTest>();
            BenchmarkRunner.Run<StartsWithTest>();
            BenchmarkRunner.Run<NotStartsWithTest>();
            BenchmarkRunner.Run<EndsWithTest>();
            BenchmarkRunner.Run<NotEndsWithTest>();
            BenchmarkRunner.Run<MatchTest>();
            BenchmarkRunner.Run<NotMatchTest>();

            // comparable
            BenchmarkRunner.Run<MoreThanTest>();
            BenchmarkRunner.Run<LessThanTest>();
            BenchmarkRunner.Run<MaxTest>();
            BenchmarkRunner.Run<MinTest>();
            BenchmarkRunner.Run<InRangeTest>();

            // enumerable
            BenchmarkRunner.Run<CountNotEqualTest>();
            BenchmarkRunner.Run<CountEqualTest>();
            BenchmarkRunner.Run<CountMoreThanTest>();
            BenchmarkRunner.Run<CountLessThanTest>();
            BenchmarkRunner.Run<MinCountTest>();
            BenchmarkRunner.Run<MaxCountTest>();
            BenchmarkRunner.Run<MethodTests.Enumerable.ContainsTest>();
            BenchmarkRunner.Run<MethodTests.Enumerable.NotContainsTest>();
            BenchmarkRunner.Run<EmptyTest>();
            BenchmarkRunner.Run<NotEmptyTest>();
            BenchmarkRunner.Run<MethodTests.Enumerable.NullOrEmptyTest>();
            BenchmarkRunner.Run<MethodTests.Enumerable.NotNullOrEmptyTest>();

            // digit
            BenchmarkRunner.Run<NegativeTest>();
            BenchmarkRunner.Run<NegativeOrZeroTest>();
            BenchmarkRunner.Run<PositiveTest>();
            BenchmarkRunner.Run<PositiveOrZeroTest>();
            BenchmarkRunner.Run<ZeroTest>();
            BenchmarkRunner.Run<NotZeroTest>();

            // enum
            BenchmarkRunner.Run<DefinedInEnumTest>();
            BenchmarkRunner.Run<HasFlagTest>();
            BenchmarkRunner.Run<NotHasFlagTest>();

            // condition
            BenchmarkRunner.Run<IfNotNullTest>();
    }
    }
}