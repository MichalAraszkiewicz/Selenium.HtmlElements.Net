﻿using System;
using System.Collections;
using System.Linq;

namespace HtmlElements.Extensions
{
    /// <summary>
    ///     Extension methods working with strings
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Convert collection to string representation.
        /// </summary>
        /// <param name="enumerable">Collection to convert</param>
        /// <returns>
        ///     String containing collection items converted to string and separated with commas
        /// </returns>
        public static String ToCommaSeparatedString(this IEnumerable enumerable)
        {
            return String.Join(",", enumerable);
        }
    }
}