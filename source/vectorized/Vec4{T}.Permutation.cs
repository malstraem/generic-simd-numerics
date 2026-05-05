using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

// calls in right cases
public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> Permute([ConstantExpected] byte e0, [ConstantExpected] byte e1,
                             [ConstantExpected] byte e2, [ConstantExpected] byte e3)
    {
        if (SizeOf<T>() == 4)
            return this.As128().Permute32(e0, e1, e2, e3).Vec4();

        return this.As256().Permute64(e0, e1, e2, e3).Vec4();
    }

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> Insert([ConstantExpected] int to, [ConstantExpected] int from, Vec4<T> other)
    {
        if (SizeOf<T>() == 4)
            return this.As128().WithElement(to, other.As128()[from]).Vec4();

        return this.As256().WithElement(to, other.As256()[from]).Vec4();
    }

    //[MethodImpl(AggressiveInlining)]
    //internal Vec4<T> SwapXY([ConstantExpected] int i, Vec4<T> other)
    //{
    //    if (SizeOf<T>() == 4)
    //    {
    //        var temp = this.As128().GetLower();

    //        return this.As128().WithElement(to, other.As128()[from]).Vec4();
    //    }

    //    return this.As256().WithElement(to, other.As256()[from]).Vec4();
    //}
}
