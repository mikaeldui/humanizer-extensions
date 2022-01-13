using System;
using System.Collections.Generic;
using System.Text;

namespace Humanizer
{
    public static class StringIEnumerableExtensions
    {
        public static IEnumerable<string> Pluralize(this IEnumerable<string> source, bool inputIsKnownToBeSingular = true) =>
            source.Select(s => s.Pluralize(inputIsKnownToBeSingular));

        public static IEnumerable<string> Singularize(this IEnumerable<string> source, bool inputIsKnownToBePlural = true, bool skipSimpleWords = false) =>
            source.Select(s => s.Singularize(inputIsKnownToBePlural, skipSimpleWords));
    }
}
