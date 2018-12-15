using System;

namespace ArgValidation
{
    internal static class ValidationContext
    {
        [ThreadStatic]
        internal static string ArgumentName;
    }
}
