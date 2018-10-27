using System;

namespace ArgValidation.Tests.Reflection
{
    internal class Person
    {
        public string Name { get; }
        public DateTime? BirthDate { get; }
        public string BirthPlace { get; }

        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, DateTime birthDate)
        {
            Name = name;
            BirthDate = birthDate;
        }

        public Person(string name, DateTime birthDate, string birthPlace)
        {
            Name = name;
            BirthDate = birthDate;
            BirthPlace = birthPlace;
        }
    }
}
