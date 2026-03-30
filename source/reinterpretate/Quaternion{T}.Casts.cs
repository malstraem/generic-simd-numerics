using System.Numerics;

namespace GenericNumerics;

public partial struct Quat<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vec4<T> AsVec4() => BitCast<Quat<T>, Vec4<T>>(this);

    [MethodImpl(AggressiveInlining)]
    internal static Quat<T> FromVec4(Vec4<T> vec) => BitCast<Vec4<T>, Quat<T>>(vec);
}
