namespace BigTony.Utility
{

    public class Vector2
    {

        public float x;
        public float y;

        /// <summary>
        /// Creates an empty Vector2.
        /// </summary>
        public Vector2()
        {



        }

        /// <summary>
        /// Creates a Vector2 with an 'x' and 'y' values specified.
        /// </summary>
        /// <param name="_x">The floating-point position on the x-axis.</param> 
        /// <param name="_y">The floating-point position on the y-axis.</param>
        public Vector2(float _x, float _y)
        {

            x = _x;
            y = _y;

        }

        /// <summary>
        /// Add two Vector2's together. 
        /// </summary>
        /// <param name="a">The first Vector to add.</param>
        /// <param name="b">The second Vector to add.</param>
        /// <returns>The sum of the two Vectors. </returns>
        public static Vector2 operator +(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x + b.x, a.y + b.y);

        }

        /// <summary>
        /// Subtract a Vector2 from another.
        /// </summary>
        /// <param name="a">The original Vector.</param>
        /// <param name="b">The Vector that will be subtracted from the original Vector.</param>
        /// <returns>The difference between the two Vectors.</returns>
        public static Vector2 operator -(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x - b.x, a.y - b.y);

        }

        /// <summary>
        /// Divide a Vector2 from another. Note, if B has any axis-values equal to 0, a DivideByZeroException will be thrown.
        /// </summary>
        /// <param name="a">The Vector in the numberator place.</param>
        /// <param name="b">The Vector in the denomonator place.</param>
        /// <returns>The divided Vector.</returns>
        public static Vector2 operator /(Vector2 a, Vector2 b)
        {

            if (b.x == 0 || b.y == 0) throw new System.DivideByZeroException();

            return new Vector2(a.x / b.x, a.y / b.y);

        }

        /// <summary>
        /// Multiply a Vector2 with another.
        /// </summary>
        /// <param name="a">The Vector to be Multiplied.</param>
        /// <param name="b">The Vector multiplying the other.</param>
        /// <returns>The multiplied Vector.</returns>
        public static Vector2 operator *(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x * b.x, a.y * b.y);

        }

        /// <summary> 
        /// Multiply a Vector2 with a floating-point number.
        /// </summary>
        /// <param name="a">The Vector to be Mutliplied.</param>
        /// <param name="b">The floating-point number multiplying the Vector.</param>
        /// <returns>The multiplied Vector.</returns>
        public static Vector2 operator *(Vector2 a, float b)
        {

            return new Vector2(a.x * b, a.y * b);

        }

        /// <summary>
        /// Divide a Vector2 by a floating-point number. Note, if B is equal to zero, a DivideByZeroException will be thrown.
        /// </summary>
        /// <param name="a">The Vector in the numerator.</param>
        /// <param name="b">The floating-point number in the denomonator.</param>
        /// <returns>A divided Vector.</returns>
        public static Vector2 operator /(Vector2 a, float b)
        {

            if (b == 0) throw new System.DivideByZeroException();

            return new Vector2(a.x / b, a.y / b);

        }

    }

}

