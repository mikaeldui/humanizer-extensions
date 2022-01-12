namespace Humanizer
{
    public static class StringIListExtensions
    {
        public static void PluralizeFirst(this IList<string> source, bool inputIsKnownToBeSingular = true) =>
            source[0] = source[0].Pluralize(inputIsKnownToBeSingular);

        public static void PluralizeLast(this IList<string> source, bool inputIsKnownToBeSingular = true) =>
            source[^1] = source[^1].Pluralize(inputIsKnownToBeSingular);

        public static void SingularizeFirst(this IList<string> source, bool inputIsKnownToBePlural = true, bool skipSimpleWords = false) =>
            source[0] = source[0].Singularize(inputIsKnownToBePlural, skipSimpleWords);

        public static void SingularizeLast(this IList<string> source, bool inputIsKnownToBePlural = true, bool skipSimpleWords = false) =>
            source[^1] = source[^1].Singularize(inputIsKnownToBePlural, skipSimpleWords);
    }
}