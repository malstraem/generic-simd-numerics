namespace System.Numerics;

public static class Vec4Extensions
{
    extension<T>(Vec4<T> a)
        where T : unmanaged, INumber<T>
    {
        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Estimate(T b, Vec4<T> c)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
                return a.As128().Estimate(Vector128.Create(b), c.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
                return a.As256().Estimate(Vector256.Create(b), c.As256()).Vec4();

            return (a * b) + c;
        }

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Estimate(Vec4<T> b, Vec4<T> c)
        {
            if (SizeOf<T>() == 4 && Vector128<T>.IsSupported)
                return a.As128().Estimate(b.As128(), c.As128()).Vec4();

            if (SizeOf<T>() == 8 && Vector256<T>.IsSupported)
                return a.As256().Estimate(b.As256(), c.As256()).Vec4();

            return a.MultiplyWise(b) + c;
        }
    }

    extension<T>(Vec4<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => v.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec4<T> other) => v.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Normalize() => v.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> SquareRoot() => v.SquareRoot<T>();
    }
}

public static class Vec4StaticExtensions
{
    extension<T>(Vec4)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec4<T> v) => Vec4.Length<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec4<T> a, Vec4<T> b) => Vec4.Distance<T, T>(a, b);

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> Normalize(Vec4<T> v) => Vec4.Normalize<T, T>(v);

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> SquareRoot(Vec4<T> v) => Vec4.SquareRoot<T, T>(v);
    }
}
