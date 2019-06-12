using System;
using ArgValidation.Internal.ExceptionThrowers;

namespace ArgValidation
{
    /// <summary>
    /// Contains extension methods for <see cref="Enum"/> type
    /// </summary>
    public static class ArgumentEnumExtension
    {
        /// <summary>
        /// <para>Throws <see cref="ArgumentException"/> if the argument is not defined in enum <typeparamref name="TEnum"/>.</para>
        /// <para>Also works with flags.</para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument is not defined in enum <typeparamref name="TEnum"/></exception>
        public static Argument<TEnum> DefinedInEnum<TEnum>(this Argument<TEnum> arg)
            where TEnum : Enum
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!DefinedInEnum(arg.Value))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must be defined in enum type {typeof(TEnum).FullName}. Current value: {arg.Value}");

            return arg;
        }

        /// <summary>
        /// <para>Throws <see cref="ArgumentException"/> if the argument not has <paramref name="flag"/></para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument not has <paramref name="flag"/></exception>
        public static Argument<TEnum> HasFlag<TEnum>(this Argument<TEnum> arg, TEnum flag) where TEnum : Enum
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (!arg.Value.HasFlag(flag))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must have the nexts flag(s): {flag}. Current value: {arg.Value}");

            return arg;
        }

        /// <summary>
        /// <para>Throws <see cref="ArgumentException"/> if the argument has <paramref name="flag"/></para>
        /// </summary>
        /// <exception cref="ArgumentException">Throws if the argument has <paramref name="flag"/></exception>
        public static Argument<TEnum> NotHasFlag<TEnum>(this Argument<TEnum> arg, TEnum flag) where TEnum : Enum
        {
            if (arg.ValidationIsDisabled())
                return arg;

            if (arg.Value.HasFlag(flag))
                ValidationErrorExceptionThrower.ArgumentException(arg, 
                    $"Argument '{arg.Name}' must not have the nexts flag(s): {flag}. Current value: {arg.Value}");

            return arg;
        }

        internal static bool DefinedInEnum(Enum en)
        {
            bool result = !decimal.TryParse(en.ToString(), out _);
            return result;
        }
    }
}
