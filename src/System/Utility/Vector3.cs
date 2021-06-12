namespace BigTony.Utility
{

    public class Vector3
    {

        public float x;
        public float y;
        public float z;

        // public float magnitude { get { return (float)Mathf.Sqrt(x * x + y * y + z * z); } }

        public Vector3()
        {



        }

        public Vector3(float _x, float _y)
        {

            x = _x;
            y = _y;

        }


        public Vector3(float _x, float _y, float _z)
        {

            x = _x;
            y = _y;
            z = _z;

        }

        public static Vector3 Add(Vector3 a, Vector3 b)
        {

            return new Vector3(a.x + b.x, a.y + b.y, a.z + b.z);

        }

    }

}

