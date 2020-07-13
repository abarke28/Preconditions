using System;

namespace Preconditions
{
    public static class Preconditions
    {
        public static void CheckNotNull(string input, string parameterName)
        {
            if (string.IsNullOrEmpty(input)) throw new ArgumentNullException(parameterName);
        }

        public static void CheckPositive(int input, string parameterName)
        {
            if (input <= 0) throw new ArgumentOutOfRangeException(parameterName);
        }

        public static void CheckNonNegative(int input, string parameterName)
        {
            if (input < 0) throw new ArgumentOutOfRangeException(parameterName);
        }


    }
}
