using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Preconditions
{
    public static class Preconditions<T>
    {
        /// <summary>
        /// Throws exception if string is null or empty
        /// </summary>
        public static void CheckNotNullOrEmpty(string input, string parameterName)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if string is null
        /// </summary>
        public static void CheckNotNull(string input, string parameterName)
        {
            if (input == null) throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is 0
        /// </summary>
        public static void CheckNotZero(int input, string parameterName)
        {
            if (input == 0) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is less than or equal to zero
        /// </summary>
        public static void CheckPositive(int input, string parameterName)
        {
            if (input <= 0) throw new ArgumentOutOfRangeException(parameterName);
        }
        
        /// <summary>
        /// Throws exception if input is less than or equal to zero
        /// </summary>
        public static void CheckPositive(double input, string parameterName)
        {
            if (input <= 0) throw new ArgumentOutOfRangeException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is less than zero
        /// </summary>
        public static void CheckNonNegative(int input, string parameterName)
        {
            if (input < 0) throw new ArgumentOutOfRangeException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is not in supplied range 
        /// </summary>
        /// <param name="inclusive">Specifies if range is inclusive (default) or exclusive</param>
        public static void CheckInRange(int input, int lowerBound, int upperBound, string parameterName, bool inclusive = true)
        {
            if (inclusive)
            {
                if (input > upperBound || input < lowerBound) throw new ArgumentOutOfRangeException(parameterName);
            }

            if (input >= upperBound || input < lowerBound) throw new ArgumentOutOfRangeException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is in supplied ranage
        /// </summary>
        /// <param name="inclusive">Specifies if range is inclusive (default) or exclusive</param>
        public static void CheckNotInRange(int input, int lowerBound, int upperBound, string parameterName, bool inclusive = true)
        {
            if (inclusive)
            {
                if (input >= lowerBound || input <= upperBound) throw new ArgumentOutOfRangeException(parameterName);
            }

            if (input > lowerBound || input < lowerBound) throw new ArgumentOutOfRangeException(parameterName);
        }

        /// <summary>
        /// Throws excpetion if input is null
        /// </summary>
        public static void CheckNotNull(T input, string parameterName)
        {
            if (input == null) throw new ArgumentNullException(parameterName);
        }

        /// <summary>
        /// Throws excpetion if input contains duplicates
        /// </summary>
        public static void CheckDistinct(IEnumerable<T> input, string parameterName)
        {
            var hs = new HashSet<T>();

            foreach (var e in input)
            {
                if (!hs.Add(e)) throw new ArgumentException(parameterName);
            }
        }

        /// <summary>
        /// Throws exception if input does not contain target
        /// </summary>
        public static void CheckContains(IEnumerable<T> input, T target, string parameterName)
        {
            if (!input.Contains(target)) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is null or whitespace
        /// </summary>
        public static void CheckNotNullOrWhiteSpace(string input, string parameterName)
        {
            if (string.IsNullOrWhiteSpace(input)) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is false
        /// </summary>
        public static void CheckTrue(bool input, string parameterName)
        {
            if (input != true) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is true
        /// </summary>
        public static void CheckFalse(bool input, string parameterName)
        {
            if (input != false) throw new ArgumentException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is not greater than threshold
        /// </summary>
        public static void CheckGreaterThan(int input, int threshold, string parameterName)
        {
            if (!(input > threshold)) throw new ArgumentOutOfRangeException(parameterName);
        }

        /// <summary>
        /// Throws exception if input is not less than threshold
        /// </summary>
        public static void CheckLessThan(int input, int threshold, string parameterName)
        {
            if (!(input < threshold)) throw new ArgumentOutOfRangeException(parameterName);
        }
    }
}