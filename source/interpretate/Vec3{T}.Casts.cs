using System.Runtime.Intrinsics;

namespace System.Numerics;

public partial struct Vec3<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128()
    {
        var vec = this;
        return Vector128.Create(Unsafe.As<Vec3<T>, Vector64<T>>(ref vec), Vector64.Create(vec.Z));
    }

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256()
    {
        var vec = this;
        return Vector256.Create(Unsafe.As<Vec3<T>, Vector128<T>>(ref vec), Vector128.Create(vec.Z));
    }

    //[MethodImpl(AggressiveInlining)]
    //internal readonly Vector128<float> As128F()
    //{
    //    var vec = this;
    //    return Vector128.Create(Unsafe.As<Vec3<T>, Vector64<float>>(ref vec), Vector64.Create<float>(float.CreateSaturating(vec.Z)));
    //}

    //[MethodImpl(AggressiveInlining)]
    //internal readonly Vector256<double> As256D()
    //{
    //    var vec = this;
    //    return Vector256.Create(Unsafe.As<Vec3<T>, Vector128<double>>(ref vec), Vector128.Create<double>(double.CreateSaturating(vec.Z)));
    //}

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From128(Vector128<T> vec) => Unsafe.As<Vector128<T>, Vec3<T>>(ref vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From256(Vector256<T> vec) => Unsafe.As<Vector256<T>, Vec3<T>>(ref vec);

    //[MethodImpl(AggressiveInlining)]
    //internal static Vec3<T> From128(Vector128<float> vec) => Unsafe.BitCast<Vector128<float>, Vec4<T>>(vec);

    //[MethodImpl(AggressiveInlining)]
    //internal static Vec3<T> From256(Vector256<double> vec) => Unsafe.BitCast<Vector256<double>, Vec4<T>>(vec);
}
