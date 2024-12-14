using System;

namespace WorkingWithDelegates
{
    public static class Delegates
    {
        public delegate float Calculate (float x, float z);

        public static float Add (float x, float z)
        {
            return x + z;
        }

        public static float Sustract (float x, float z)
        {
            return x + z;
        }

        public static float Multiply (float x, float z)
        {
            return x * z;
        }

        public static float Divide (float x, float z)
        {
            if (z == 0)
            {
                throw new DivideByZeroException();
            }

            return x / z;
        }

    }
}