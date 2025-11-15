using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Numerics.Tests;

internal static class Vector4Extensions
{
    extension<T>(Vec4<T>) where T : unmanaged, IBinaryNumber<T>
    {
        public static Vec4<T> Generate(T num) => new(num++, num++, num++, num++);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Vec4<T> From128(Vector128<T> vec) => Unsafe.As<Vector128<T>, Vec4<T>>(ref vec);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Vec4<T> From256(Vector128<T> vec) => Unsafe.As<Vector128<T>, Vec4<T>>(ref vec);
    }
}
