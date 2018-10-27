using System;
using ArgValidation.Examples;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using NameOf = ArgValidation.Examples.Model.ArgValidation.NameOf;
using ExpressionTree = ArgValidation.Examples.Model.ArgValidation.ExpressionTree;
using Native = ArgValidation.Examples.Model.Native;

namespace ArgValidation.Tests.Performance
{
    [CoreJob]
    [MemoryDiagnoser]
    public class NativeVsNameOfVsExpressionTree
    {
        [Params(1)] 
        public int N;

        [Benchmark]
        public void Native()
        {
            for (int i = 0; i < N; i++)
            {
                var car = new Native.Car(
                    model: new CarModel(), 
                    color: "white",
                    releaseYear: 2005, 
                    dateOfPurchase: new DateTime(2008, 01, 02));
            }
        }

        [Benchmark]
        public void NameOf()

        {
            for (int i = 0; i < N; i++)
            {
                var car = new NameOf.Car(
                    model: new CarModel(), 
                    color: "white",
                    releaseYear: 2005, 
                    dateOfPurchase: new DateTime(2008, 01, 02));
            }
        }

        [Benchmark]
        public void ExpressionTree()
        {
            for (int i = 0; i < N; i++)
            {
                var car = new ExpressionTree.Car(
                    model: new CarModel(), 
                    color: "white",
                    releaseYear: 2005, 
                    dateOfPurchase: new DateTime(2008, 01, 02));
            }
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<NativeVsNameOfVsExpressionTree>();
        }
    }
}