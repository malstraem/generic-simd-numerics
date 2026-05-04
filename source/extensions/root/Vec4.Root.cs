namespace System.Numerics;

public static class Vec4Root
{
    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => T.Sqrt(v.LengthSquared());

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec4<T> b) => T.Sqrt(v.DistanceSquared(b));

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Normalize() => v / v.Length();

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> SquareRoot()
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
                return Vector128.Sqrt(v.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated)
                return Vector256.Sqrt(v.As256()).Vec4();

            return new(T.Sqrt(v.X), T.Sqrt(v.Y), T.Sqrt(v.Z), T.Sqrt(v.W));
        }
    }
}

public static class Vec4RootStatic
{
    extension<T>(Vec4)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec4<T> v) => v.Length();

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec4<T> a, Vec4<T> b) => a.Distance(b);

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> Normalize(Vec4<T> v) => v.Normalize();

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> SquareRoot(Vec4<T> v) => v.SquareRoot();
    }
}
