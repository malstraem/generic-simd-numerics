using System.Runtime.Intrinsics.X86;

namespace System.Numerics;

// only AVX way
public static partial class Vec4
{
    [MethodImpl(AggressiveInlining)]
    public static Vec4<TOther> As<T, TOther>(Vec4<T> v)
        where T : unmanaged, INumber<T>
        where TOther : unmanaged, INumber<TOther>
    {
        if (!Avx.IsSupported)
        {
            if (typeof(T) == typeof(int))
            {
                if (typeof(TOther) == typeof(float))
                    return Avx.ConvertToVector128Single(v.As128().AsInt32()).As<float, TOther>().Vec4();

                if (typeof(TOther) == typeof(double))
                    return Avx.ConvertToVector256Double(v.As128().AsInt32()).As<double, TOther>().Vec4();
            }

            if (typeof(T) == typeof(float))
            {
                if (typeof(TOther) == typeof(int))
                    return Avx.ConvertToVector128Int32(v.As128().AsSingle()).As<int, TOther>().Vec4();

                if (typeof(TOther) == typeof(double))
                    return Avx.ConvertToVector256Double(v.As128().AsSingle()).As<double, TOther>().Vec4();
            }

            if (typeof(T) == typeof(double))
            {
                if (typeof(TOther) == typeof(int))
                    return Avx.ConvertToVector128Int32(v.As256().AsDouble()).As<int, TOther>().Vec4();

                if (typeof(TOther) == typeof(float))
                    return Avx.ConvertToVector128Single(v.As256().AsDouble()).As<float, TOther>().Vec4();
            }
        }
        return new Vec4<TOther>(
            TOther.CreateTruncating(v.X),
            TOther.CreateTruncating(v.Y),
            TOther.CreateTruncating(v.Z),
            TOther.CreateTruncating(v.W)
        );
    }
}
