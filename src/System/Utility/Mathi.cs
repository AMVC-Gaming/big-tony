namespace BigTony.Utility
{
    public static class Mathi
    {

        public static float Clamp(int val, int min, int max)
        {

            if (val < min) return min;
            if (val > max) return max;
            return val;

        }

        public static int Max(int a, int b)
        {

            return (a > b) ? a : b;

        }

        public static int Min(int a, int b)
        {

            return (a < b) ? a : b;

        }

        public static int Abs(int a)
        {

            return (a > 0) ? a : -a;

        }

    }
}
