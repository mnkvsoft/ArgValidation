using Mynkovv.Validating.Reflection;
using System;
using Xunit;

namespace Mynkovv.Validating.Tests.Reflection
{
    public partial class ReflectionObjectCreatorTest
    {
        [Fact]
        public void Create_OneArgument_Ok()
        {
            string name = "Harry Potter";

            Person t = ReflectionObjectCreator.InvokeConstructor<Person>(
                new ConstructorParameter(
                    name: nameof(name), 
                    value: name, 
                    parameterType: typeof(string)));

            Assert.Equal(name, t.Name);
            Assert.Equal(null, t.BirthDate);
        }

        [Fact]
        public void Create_TwoArguments_Ok()
        {
            string name = "Harry Potter";
            DateTime birthDate = new DateTime(1980, 7, 31);

            Person t = ReflectionObjectCreator.InvokeConstructor<Person>(
                new ConstructorParameter(
                    name: nameof(name), 
                    value: name,
                    parameterType: name.GetType()),
                new ConstructorParameter(
                    name: nameof(birthDate), 
                    value: birthDate,
                    parameterType: birthDate.GetType())
                );

            Assert.Equal(name, t.Name);
            Assert.Equal(birthDate, t.BirthDate);
        }

        [Fact]
        public void Create_WithoutParameters_Ok()
        {
            Person t = ReflectionObjectCreator.InvokeConstructor<Person>();
            Assert.Equal(null, t.Name);
            Assert.Equal(null, t.BirthDate);
            Assert.Equal(null, t.BirthPlace);
        }

        [Fact]
        public void Create_NullArgument_Ok()
        {
            string name = null;

            Person t = ReflectionObjectCreator.InvokeConstructor<Person>(
                new ConstructorParameter(
                    name: nameof(name), 
                    value: name, 
                    parameterType: typeof(string)));

            Assert.Equal(name, t.Name);
            Assert.Equal(null, t.BirthDate);
        }

        [Fact]
        public void Create_MissingConstructor_InvalidOperationException()
        {
            string missingParameter1 = "value";
            object missingParameter2 = new object();

            InvalidOperationException exc = Assert.Throws<InvalidOperationException>(() =>
                 ReflectionObjectCreator.InvokeConstructor<Person>(
                     new ConstructorParameter(
                         name: nameof(missingParameter1), 
                         value: missingParameter1,
                         parameterType: missingParameter1.GetType()),
                     new ConstructorParameter(
                         name: nameof(missingParameter2), 
                         value: missingParameter2,
                         parameterType: missingParameter2.GetType())
            ));

            string expected = $"Failed to create object. Constructor Person({missingParameter1.GetType().Name} {nameof(missingParameter1)}, {missingParameter2.GetType().Name} {nameof(missingParameter2)}) was not found";
            Assert.Equal(expected, exc.Message);
        }
    }
}
