using Silk.NET.Maths;

namespace System.Numerics;

public static class QuatExtensions
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        public static Quat<T> Gen(T num) => new(num++, num++, num++, T.One);

        public Quaternion<T> Silk() => new(q.X, q.Y, q.Z, q.W);
    }

    extension<T>(Quaternion<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        public Quat<T> Quat() => new(q.X, q.Y, q.Z, q.W);
    }

    extension(Quat<float> q)
    {
        public Quaternion System() => new(q.X, q.Y, q.Z, q.W);
    }
}
