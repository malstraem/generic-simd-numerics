using Silk.NET.Maths;

namespace System.Numerics;

internal static class VecExtensions
{
    extension<T>(Vec4<T> vec) where T : unmanaged, INumber<T>
    {
        public static Vec4<T> Gen(T num) => new(num++, num++, num++, num++);

        public Vector4D<T> Silk() => new(vec.X, vec.Y, vec.Z, vec.W);
    }

    extension<T>(Vector4D<T> vec) where T : unmanaged, INumber<T>
    {
        public Vec4<T> Vec4() => new(vec.X, vec.Y, vec.Z, vec.W);
    }

    extension(Vec4<float> vec)
    {
        public Vector4 System() => new(vec.X, vec.Y, vec.Z, vec.W);
    }

    extension(Vector4 vec)
    {
        public static Vector4 Gen(float num) => new(num++, num++, num++, num++);
    }
}
