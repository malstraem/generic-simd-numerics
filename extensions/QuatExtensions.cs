using Silk.NET.Maths;

namespace System.Numerics;

using static Runtime.CompilerServices.Unsafe;

internal static class QuatExtensions
{
    extension<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal static Quat<T> Gen(T num) => new(num++, num++, num++, T.One);

        internal Quaternion<T> Silk() => BitCast<Quat<T>, Quaternion<T>>(q);
    }

    extension<T>(Quaternion<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        internal Quat<T> Quat() => BitCast<Quaternion<T>, Quat<T>>(q);
    }

    extension(Quat<float> q)
    {
        internal Quaternion System() => BitCast<Quat<float>, Quaternion>(q);
    }

    extension(Quaternion q)
    {
        internal Quat<float> Quat() => BitCast<Quaternion, Quat<float>>(q);
    }
}
