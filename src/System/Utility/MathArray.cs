namespace BigTony.Utility
{
    public static class MathArray
    {

        /// <summary>
        /// Clamp a series of floating-point numbers between a maximum and minimum amount.
        /// </summary>
        /// <param name="input">The values that need to be clamped.</param>
        /// <param name="min">The minimum amount that the values of 'input' can be.</param>
        /// <param name="max">The maximum amount that the values of 'input' can be.</param>
        /// <returns>The clamped values of 'input' between 'min' and 'max'.</returns>
        public static float[] Clamp(float[] input, float min, float max)
        {

            float[] output = new float[input.Length];

            for (int i = 0; i < input.Length; i++)
            {


                if (input[i] < min)
                {

                    output[i] = min;

                }
                else if (input[i] > max)
                {

                    output[i] = max;

                }
                else
                {

                    output[i] = input[i];

                }

            }

            return output;

        }

        /// <summary>
        /// Get the lowest value of a floating-point data set. If the dataset's length is 0, then float.MaxValue will be returned.
        /// </summary>
        /// <param name="input">A floating-point dataset in the form of an array.</param>
        /// <returns>The lowest value of the floating-point data set.</returns>
        public static float Min(float[] input)
        {

            float output = float.MaxValue;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] < output) output = input[i];

            }

            return output;

        }

        /// <summary>
        /// Get the highest value of a floating-point data set. If the dataset's length is 0, then float.MinValue will be returned.
        /// </summary>
        /// <param name="input">A floating-point dataset in the form of an array.</param>
        /// <returns>The highest value of the floating-point data set.</returns>
        public static float Max(float[] input)
        {

            float output = float.MinValue;

            for (int i = 0; i < input.Length; i++)
            {

                if (input[i] > output) output = input[i];

            }

            return output;

        }

        /// <summary>
        /// Get the absolute value of a set of floating-point data. 
        /// </summary>
        /// <param name="input">The floating-point data to get the absolute value of.</param>
        /// <returns>The absolute value of the floating-point data inputted.</returns>
        public static float[] Abs(float[] input)
        {

            float[] output = new float[input.Length];

            for (int i = 0; i < input.Length; i++)
            {

                output[i] = (input[i] > 0) ? input[i] : -input[i];

            }

            return output;

        }

    }
}
