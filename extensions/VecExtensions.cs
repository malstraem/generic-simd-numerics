using System.Runtime.CompilerServices;

using Silk.NET.Maths;

namespace System.Numerics;

// only for tests
internal static class Vec2Extensions
{
    extension<T>(Vec2<T> v)
        where T : unmanaged, INumber<T>
    {
        internal static Vec2<T> Gen(T num) => new(num++, num++);

        internal Vector2D<T> Silk() => new(v.X, v.Y);
    }

    extension<T>(Vector2D<T> v)
        where T : unmanaged, INumber<T>
    {
        internal Vec2<T> Vec2() => new(v.X, v.Y);
    }

    extension(Vec2<float> v)
    {
        internal Vector2 System() => new(v.X, v.Y);
    }
}

internal static class Vec3Extensions
{
    extension<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>
    {
        internal static Vec3<T> Gen(T num) => new(num++, num++, num++);

        internal Vector3D<T> Silk() => new(v.X, v.Y, v.Z);

        internal Vector3 System() => Unsafe.BitCast<Vec3<T>, Vec3<float>>(v).System();
    }

    extension<T>(Vector3D<T> v)
        where T : unmanaged, INumber<T>
    {
        internal Vec3<T> Vec3() => new(v.X, v.Y, v.Z);
    }

    extension(Vec3<float> v)
    {
        internal Vector3 System() => new(v.X, v.Y, v.Z);
    }
}

internal static class Vec4Extensions
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>
    {
        internal static Vec4<T> Gen(T num) => new(num++, num++, num++, num++);

        internal Vector4D<T> Silk() => new(v.X, v.Y, v.Z, v.W);
    }

    extension<T>(Vector4D<T> v)
        where T : unmanaged, INumber<T>
    {
        internal Vec4<T> Vec4() => new(v.X, v.Y, v.Z, v.W);
    }

    extension(Vec4<float> v)
    {
        internal Vector4 System() => new(v.X, v.Y, v.Z, v.W);
    }
}
