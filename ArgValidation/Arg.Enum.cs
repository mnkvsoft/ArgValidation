using System;
using System.Linq.Expressions;

namespace ArgValidation
{
    public static partial class Arg
    {
        /// <summary>
        /// <para>Throws <see cref="ArgumentException"/> if the argument is not defined in enum <typeparamref name="TEnum"/>.</para>
        /// <para>Also works with flags.</para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not defined in enum <typeparamref name="TEnum"/></exception>
        public static TEnum DefinedInEnum<TEnum>(TEnum argValue, string argName) where TEnum : Enum
        {
            return Validate(argValue, argName).DefinedInEnum().Value;
        }

        /// <summary>
        /// <para>Throws <see cref="ArgumentException"/> if the argument is not defined in enum <typeparamref name="TEnum"/>.</para>
        /// <para>Also works with flags.</para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not defined in enum <typeparamref name="TEnum"/></exception>
        public static TEnum DefinedInEnum<TEnum>(Expression<Func<TEnum>> value) where TEnum : Enum
        {
            return Validate(value).DefinedInEnum().Value;
        }
    }
}