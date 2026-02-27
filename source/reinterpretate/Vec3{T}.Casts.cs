namespace System.Numerics;

public partial struct Vec3<T>
{
    [MethodImpl(AggressiveInlining)]
    internal readonly Vector128<T> As128()
    {
        // something smarter?

        /*var vec = Vector128<T>.AllBitsSet;

        vec = vec.WithElement(0, X);
        vec = vec.WithElement(1, Y);
        vec = vec.WithElement(2, Z);

        return vec;*/

        SkipInit(out Vector128<T> result);

        Unsafe.Add(ref As<Vector128<T>, T>(ref AsRef(in result)), 0) = X;
        Unsafe.Add(ref As<Vector128<T>, T>(ref AsRef(in result)), 1) = Y;
        Unsafe.Add(ref As<Vector128<T>, T>(ref AsRef(in result)), 2) = Z;
        Unsafe.Add(ref As<Vector128<T>, T>(ref AsRef(in result)), 3) = T.One;

        return result;

        /*if (typeof(T) == typeof(float))
        {
            return BitCast<Vector128<float>, Vector128<T>>(
                Vector128.Create((float)(object)X, (float)(object)Y, (float)(object)Z, 1f));
        }

        var vec = this;
        return Vector128.Create(As<Vec3<T>, Vector64<T>>(ref vec), Vector64.Create(vec.Z));*/
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
