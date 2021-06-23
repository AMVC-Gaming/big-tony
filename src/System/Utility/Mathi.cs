namespace BigTony.Utility
{
    public static class Mathi
    {

        /// <summary>
        /// Clamp an integer between a maximum and minimum amount.
        /// </summary>
        /// <param name="val">The value of the integer that needs to be clamped.</param>
        /// <param name="min">The minimum amount that 'val' can be, as an integer.</param>
        /// <param name="max">The maximum amount that 'val' can be, as an integer.</param>
        /// <returns>A clamped value of 'val' between 'min' and 'max'.</returns>
        public static float Clamp(int val, int min, int max)
        {

            if (val < min) return min;
            if (val > max) return max;
            return val;

        }

        /// <summary>
        /// Get the highest value between two inputted integers.
        /// </summary>
        /// <param name="a">The first integer to be compared.</param>
        /// <param name="b">The second integer to be compared.</param>
        /// <returns>The highest value between 'a' and 'b'.</returns>
        public static int Max(int a, int b)
        {

            return (a > b) ? a : b;

        }

        /// <summary>
        /// Get the lowest value between two inputted integers.
        /// </summary>
        /// <param name="a">The first integer number to be compared.</param>
        /// <param name="b">The second integer number to be compared.</param>
        /// <returns>The lowest value between 'a' and 'b'.</returns>  
        public static int Min(int a, int b)
        {

            return (a < b) ? a : b;

        }

        /// <summary>
        /// Get the absolute value of the inputted integer.
        /// </summary>
        /// <param name="a">The integer to get the absolute value of.</param>
        /// <returns>The absolute value of 'a'.</returns>
        public static int Abs(int a)
        {

            return (a > 0) ? a : -a;

        }

    }
}
