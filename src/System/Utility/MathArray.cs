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

    }
}
