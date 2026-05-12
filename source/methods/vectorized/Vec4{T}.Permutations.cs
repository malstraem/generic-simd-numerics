using System.Diagnostics.CodeAnalysis;

namespace System.Numerics;

public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> Insert([ConstantExpected] int to, [ConstantExpected] int from, Vec4<T> other)
    {
        if (SizeOf<T>() == 4)
            return this.As128().WithElement(to, other.As128()[from]).Vec4();

        return this.As256().WithElement(to, other.As256()[from]).Vec4();
    }

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> Permute([ConstantExpected] byte e0, [ConstantExpected] byte e1,
                         [ConstantExpected] byte e2, [ConstantExpected] byte e3)
    {
        if (SizeOf<T>() == 4)
            return this.As128().Permute32(e0, e1, e2, e3).Vec4();

        return this.As256().Permute64(e0, e1, e2, e3).Vec4();
    }

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XXXX() => Permute(0, 0, 0, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YYYY() => Permute(1, 1, 1, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZZZZ() => Permute(2, 2, 2, 2);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WWWW() => Permute(3, 3, 3, 3);

    #region X---
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XYWZ() => Permute(0, 1, 3, 2);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XZYW() => Permute(0, 2, 1, 3);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XZWY() => Permute(0, 2, 3, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XWZY() => Permute(0, 3, 2, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> XWYZ() => Permute(0, 3, 1, 2);
    #endregion

    #region Y---
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YXZW() => Permute(1, 0, 2, 3);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YXWZ() => Permute(1, 0, 3, 2);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YZXW() => Permute(1, 2, 0, 3);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YZWX() => Permute(1, 2, 3, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YWZX() => Permute(1, 3, 2, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> YWXZ() => Permute(1, 3, 0, 2);
    #endregion

    #region Z---
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZXYW() => Permute(2, 0, 1, 3);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZXWY() => Permute(2, 0, 3, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZYXW() => Permute(2, 1, 0, 3);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZYWX() => Permute(2, 1, 3, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZWYX() => Permute(2, 3, 1, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> ZWXY() => Permute(2, 3, 0, 1);
    #endregion

    #region W---
    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WXYZ() => Permute(3, 0, 1, 2);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WXZY() => Permute(3, 0, 2, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WYXZ() => Permute(3, 1, 0, 2);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WYZX() => Permute(3, 1, 2, 0);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WZXY() => Permute(3, 2, 0, 1);

    [MethodImpl(AggressiveInlining)]
    internal Vec4<T> WZYX() => Permute(3, 2, 1, 0);
    #endregion
}
