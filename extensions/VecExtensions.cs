using Silk.NET.Maths;

namespace System.Numerics;

internal static class Vec2Extensions
{
    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
    {
        public static Vec2<T> Gen(T num) => new(num++, num++);

        public Vector2D<T> Silk() => new(v.X, v.Y);
    }

    extension<T>(Vector2D<T> v)
        where T : unmanaged, INumber<T>
    {
        public Vec2<T> Vec2() => new(v.X, v.Y);
    }

    extension(Vec2<float> v)
    {
        public Vector2 System() => new(v.X, v.Y);
    }
}

internal static class Vec3Extensions
{
    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
    {
        public static Vec3<T> Gen(T num) => new(num++, num++, num++);

        public Vector3D<T> Silk() => new(v.X, v.Y, v.Z);
    }

    extension<T>(Vector3D<T> v)
        where T : unmanaged, INumber<T>
    {
        public Vec3<T> Vec3() => new(v.X, v.Y, v.Z);
    }

    extension(Vec3<float> v)
    {
        public Vector3 System() => new(v.X, v.Y, v.Z);
    }
}

internal static class Vec4Extensions
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        public static Vec4<T> Gen(T num) => new(num++, num++, num++, num++);

        public Vector4D<T> Silk() => new(v.X, v.Y, v.Z, v.W);
    }

    extension<T>(Vector4D<T> v)
        where T : unmanaged, INumber<T>
    {
        public Vec4<T> Vec4() => new(v.X, v.Y, v.Z, v.W);
    }

    extension(Vec4<float> v)
    {
        public Vector4 System() => new(v.X, v.Y, v.Z, v.W);
    }
}
