namespace System.Numerics;

public static class Vec4Extensions
{
    extension<T>(Vec4<T> vec)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public T Length() => vec.Length<T>();

        [MethodImpl(AggressiveInlining)]
        public T Distance(Vec4<T> other) => vec.Distance<T>(other);

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> Normalize() => vec.Normalize<T>();

        [MethodImpl(AggressiveInlining)]
        public Vec4<T> SquareRoot() => vec.SquareRoot<T>();
    }
}

public static class Vec4StaticExtensions
{
    extension<T>(Vec4<T>)
        where T : unmanaged, INumber<T>, IRootFunctions<T>
    {
        [MethodImpl(AggressiveInlining)]
        public static T Length(Vec4<T> vec) => Vec4<T>.Length<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static T Distance(Vec4<T> left, Vec4<T> right) => Vec4<T>.Distance<T>(left, right);

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> Normalize(Vec4<T> vec) => Vec4<T>.Normalize<T>(vec);

        [MethodImpl(AggressiveInlining)]
        public static Vec4<T> SquareRoot(Vec4<T> vec) => Vec4<T>.SquareRoot<T>(vec);
    }
}
