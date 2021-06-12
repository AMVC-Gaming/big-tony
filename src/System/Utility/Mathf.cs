namespace BigTony.Utility
{
    public static class Mathf
    {

        /// <summary>
        /// Linear-Interpolate a certain distance between two floating point numbers.
        /// </summary>
        /// <param name="a">The first value to be interpolated between.</param>
        /// <param name="b">The second value to be interpolated between.</param>
        /// <param name="t">The amount that needs to be interpolated. This is expressed as a decimal value between '0' and '1'.</param>
        /// <returns>The number that is 't' distance between 'a' and 'b'.</returns>
        public static float Lerp(float a, float b, float t)
        {

            return a * (1 - t) + b * t;

        }

        /// <summary>
        /// Clamp a floating-point number between a maximum and minimum amount.
        /// </summary>
        /// <param name="val">The value of the number that needs to be clamped.</param>
        /// <param name="min">The minimum amount that 'val' can be.</param>
        /// <param name="max">The maximum amount that 'val' can be.</param>
        /// <returns>A clamped value of 'val' between 'min' and 'max'.</returns>
        public static float Clamp(float val, float min, float max)
        {

            if (val < min) return min;
            if (val > max) return max;
            return val;

        }

        /// <summary>
        /// Get the highest value between two inputted floating-point numbers.
        /// </summary>
        /// <param name="a">The first floating-point number to be compared.</param>
        /// <param name="b">The second floating-point number to be compared.</param>
        /// <returns>The highest value between 'a' and 'b'.</returns>
        public static float Max(float a, float b)
        {

            return (a > b) ? a : b;

        }

        /// <summary>
        /// Get the lowest value between two inputted floating-point numbers.
        /// </summary>
        /// <param name="a">The first floating-point number to be compared.</param>
        /// <param name="b">The second floating-point number to be compared.</param>
        /// <returns>The lowest value between 'a' and 'b'.</returns> 
        public static float Min(float a, float b)
        {

            return (a < b) ? a : b;

        }

        /// <summary>
        /// Get the absolute value of the inputted floating-point number.
        /// </summary>
        /// <param name="a">The floating-point number to get the absolute value of.</param>
        /// <returns>The absolute value of 'a'.</returns>
        public static float Abs(float a)
        {

            return (a > 0) ? a : -a;

        }

    }
}
