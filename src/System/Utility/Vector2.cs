namespace BigTony.Utility
{

    public class Vector2
    {

        public float x;
        public float y;

        public Vector2()
        {



        }

        public Vector2(float _x, float _y)
        {

            x = _x;
            y = _y;

        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x + b.x, a.y + b.y);

        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x - b.x, a.y - b.y);

        }

        public static Vector2 operator /(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x / b.x, a.y / b.y);

        }

        public static Vector2 operator *(Vector2 a, Vector2 b)
        {

            return new Vector2(a.x * b.x, a.y * b.y);

        }

        public static Vector2 operator *(Vector2 a, float b)
        {

            return new Vector2(a.x * b, a.y * b);

        }

        public static Vector2 operator /(Vector2 a, float b)
        {

            return new Vector2(a.x / b, a.y / b);

        }

    }

}

