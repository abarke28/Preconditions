using System;

namespace Preconditions
{
    public static class Preconditions
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
        /// Throws exception if input is less than or equal to zero
        /// </summary>
        public static void CheckPositive(int input, string parameterName)
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
    }
}
