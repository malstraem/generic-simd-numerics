using Silk.NET.Maths;

namespace System.Numerics;

public static class QuatExtensions
{
    extension<T>(Quat<T> q) where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        public static Quat<T> Gen(T num) => new
        (
            num++, num++, num++, T.One
        );

        public Quaternion<T> Silk() => new
        (
            q.X, q.Y, q.Z, q.W
        );
    }

    extension<T>(Quaternion<T> q) where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        public Quat<T> Quat() => new
        (
            q.X, q.Y, q.Z, q.W
        );
    }

    extension(Quat<float> q)
    {
        public Quaternion System() => new
        (
            q.X, q.Y, q.Z, q.W
        );
    }
}
