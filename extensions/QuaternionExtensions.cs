using GenericNumerics;

using Silk.NET.Maths;

namespace System.Numerics;

public static class QuatExtensions
{
    extension<T>(Quat<T> value) where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        public static Quat<T> Gen(T num) => new
        (
            num++, num++, num++, T.One
        );

        public Quaternion<T> Silk() => new
        (
            value.X, value.Y, value.Z, value.W
        );
    }

    extension<T>(Quaternion<T> value) where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        public Quat<T> Quat() => new
        (
            value.X, value.Y, value.Z, value.W
        );
    }
}
