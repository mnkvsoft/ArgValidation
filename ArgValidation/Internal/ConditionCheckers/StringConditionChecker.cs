using System.Text.RegularExpressions;

namespace ArgValidation.Internal.ConditionCheckers
{
    internal static class StringConditionChecker
    {
        public static bool Match(Argument<string> arg, string pattern)
        {
#if !NET40
            Regex r = new Regex(pattern);
#else
            Regex r = new Regex(pattern, RegexOptions.Compiled);
#endif
            return r.IsMatch(arg.Value);
        }
    }
}