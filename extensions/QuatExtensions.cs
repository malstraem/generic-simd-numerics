using Silk.NET.Maths;

namespace System.Numerics;

internal static class QuatExtensions
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal static Quat<T> Gen(T num) => new(num++, num++, num++, T.One);

        internal Quaternion<T> Silk() => new(q.X, q.Y, q.Z, q.W);
    }

    extension<T>(Quaternion<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal Quat<T> Quat() => new(q.X, q.Y, q.Z, q.W);
    }

    extension(Quat<float> q)
    {
        internal Quaternion System() => new(q.X, q.Y, q.Z, q.W);
    }

    extension(Quaternion q)
    {
        internal Quat<float> Quat() => new(q.X, q.Y, q.Z, q.W);
    }
}
