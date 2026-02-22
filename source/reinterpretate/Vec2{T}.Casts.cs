using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Vec2<T>
{
    [MethodImpl(AggressiveInlining)]
    private readonly Vector64<T> As64() => Unsafe.BitCast<Vec2<T>, Vector64<T>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<T> As128() => Unsafe.BitCast<Vec2<T>, Vector128<T>>(this);

    /*[MethodImpl(AggressiveInlining)]
    private readonly Vector64<float> As64F() => Unsafe.BitCast<Vec2<T>, Vector64<float>>(this);

    [MethodImpl(AggressiveInlining)]
    private readonly Vector128<double> As128D() => Unsafe.BitCast<Vec2<T>, Vector128<double>>(this);*/

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From64(Vector64<T> vec) => Unsafe.BitCast<Vector64<T>, Vec2<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From128(Vector128<T> vec) => Unsafe.BitCast<Vector128<T>, Vec2<T>>(vec);

    /*[MethodImpl(AggressiveInlining)]
    private static Vec2<T> From64(Vector64<float> vec) => Unsafe.BitCast<Vector64<float>, Vec2<T>>(vec);

    [MethodImpl(AggressiveInlining)]
    private static Vec2<T> From128(Vector128<double> vec) => Unsafe.BitCast<Vector128<double>, Vec2<T>>(vec);*/
}
