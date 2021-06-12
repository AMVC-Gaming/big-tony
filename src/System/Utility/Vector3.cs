namespace BigTony.Utility
{

    public class Vector3
    {

        public float x;
        public float y;
        public float z;

        // public float magnitude { get { return (float)Mathf.Sqrt(x * x + y * y + z * z); } }

        /// <summary>
        /// Creates an empty Vector3.
        /// </summary>
        public Vector3()
        {



        }

        /// <summary>
        /// Creates a Vector3 with an 'x' and 'y' values specified.
        /// </summary>
        /// <param name="_x">The floating-point position on the x-axis.</param> 
        /// <param name="_y">The floating-point position on the y-axis.</param>
        public Vector3(float _x, float _y)
        {

            x = _x;
            y = _y;

        }

        /// <summary>
        /// Creates a Vector3 with an 'x', 'y', and 'z' values specified.
        /// </summary>
        /// <param name="_x">The floating-point position on the x-axis.</param> 
        /// <param name="_y">The floating-point position on the y-axis.</param>
        /// <param name="_z">The floating-point position on the z-axis.</param>
        public Vector3(float _x, float _y, float _z)
        {

            x = _x;
            y = _y;
            z = _z;

        }

        /// <summary>
        /// Add two Vector3's together. 
        /// </summary>
        /// <param name="a">The first Vector to add.</param>
        /// <param name="b">The second Vector to add.</param>
        /// <returns>The sum of the two Vectors. </returns>
        public static Vector3 operator +(Vector3 a, Vector3 b)
        {

            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);

        }

        /// <summary>
        /// Subtract a Vector3 from another.
        /// </summary>
        /// <param name="a">The original Vector.</param>
        /// <param name="b">The Vector that will be subtracted from the original Vector.</param>
        /// <returns>The difference between the two Vectors.</returns>
        public static Vector3 operator -(Vector3 a, Vector3 b)
        {

            return new Vector3(a.x - b.x, a.y - b.y, a.z - b.z);

        }

        public static Vector3 operator /(Vector3 a, Vector3 b)
        {

            return new Vector3(a.x / b.x, a.y / b.y, a.z / b.z);

        }

        public static Vector3 operator *(Vector3 a, Vector3 b)
        {

            return new Vector3(a.x * b.x, a.y * b.y, a.z * b.z);

        }

        public static Vector3 operator *(Vector3 a, float b)
        {

            return new Vector3(a.x * b, a.y * b, a.z * b);

        }

        public static Vector3 operator /(Vector3 a, float b)
        {

            return new Vector3(a.x / b, a.y / b, a.z / b);

        }

    }

}

