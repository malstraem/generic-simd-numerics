using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace System.Numerics;

// only for tests
internal static class QuatExtensions
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal static Quat<T> Gen(T num) => new(num++, num++, num++, T.One);

        internal Quaternion<T> Silk() => new(q.X, q.Y, q.Z, q.W);

        internal Quaternion System() => Unsafe.BitCast<Quat<T>, Quat<float>>(q).System();
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

    extension<T>(Quaternion q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal Quat<T> Quat() => new((T)(object)q.X, (T)(object)q.Y, (T)(object)q.Z, (T)(object)q.W);
    }
}
