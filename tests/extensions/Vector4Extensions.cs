using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;

namespace System.Numerics.Tests;

internal static class Vector4Extensions
{
    extension<T>(Vec4<T>) where T : unmanaged, IBinaryNumber<T>
    {
        public static Vec4<T> Generate(T num) => new(num++, num++, num++, num++);
    }
}
