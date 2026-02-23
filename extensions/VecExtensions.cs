using Silk.NET.Maths;

namespace System.Numerics;

internal static class Vec2Extensions
{
    extension<T>(Vec2<T> vec) where T : unmanaged, INumber<T>
    {
        public static Vec2<T> Gen(T num) => new(num++, num++);

        public Vector2D<T> Silk() => new(vec.X, vec.Y);
    }

    extension<T>(Vector2D<T> vec) where T : unmanaged, INumber<T>
    {
        public Vec2<T> Vec2() => new(vec.X, vec.Y);
    }

    extension(Vec2<float> vec)
    {
        public Vector2 System() => new(vec.X, vec.Y);
    }

    extension(Vector2 vec)
    {
        public static Vector2 Gen(float num) => new(num++, num++);
    }
}

internal static class Vec3Extensions
{
    extension<T>(Vec3<T> vec) where T : unmanaged, INumber<T>
    {
        public static Vec3<T> Gen(T num) => new(num++, num++, num++);

        public Vector3D<T> Silk() => new(vec.X, vec.Y, vec.Z);
    }

    extension<T>(Vector3D<T> vec) where T : unmanaged, INumber<T>
    {
        public Vec3<T> Vec4() => new(vec.X, vec.Y, vec.Z);
    }

    extension(Vec3<float> vec)
    {
        public Vector3 System() => new(vec.X, vec.Y, vec.Z);
    }

    extension(Vector3 vec)
    {
        public static Vector3 Gen(float num) => new(num++, num++, num++);
    }
}

internal static class Vec4Extensions
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
