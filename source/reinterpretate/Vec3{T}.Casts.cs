namespace System.Numerics;

public partial struct Vec3<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128()
    {
        var vec = this;
        return Vector128.Create(As<Vec3<T>, Vector64<T>>(ref vec), Vector64.Create(vec.Z));
    }

    [MethodImpl(AggressiveInlining)]
    internal readonly Vector256<T> As256()
    {
        var vec = this;
        return Vector256.Create(As<Vec3<T>, Vector128<T>>(ref vec), Vector128.Create(vec.Z));
    }

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From128(Vector128<T> vec) => As<Vector128<T>, Vec3<T>>(ref vec);

    [MethodImpl(AggressiveInlining)]
    internal static Vec3<T> From256(Vector256<T> vec) => As<Vector256<T>, Vec3<T>>(ref vec);
}
