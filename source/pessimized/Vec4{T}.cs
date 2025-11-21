using System.Runtime.Intrinsics;

namespace System.Numerics;

#pragma warning disable CS8509

// believe the methods should be like this
public partial struct Vec4<T>
{
    [MethodImpl(AggressiveInlining)]
    // explicit type checking should be hidden behind something like "Guard.IsHardware",
    // but the way is currently pessimized by the JIT

    // this version performs as expected
    public static Vec4<T> operator +(Vec4<T> value) => typeof(T) == typeof(double) || typeof(T) == typeof(float) ? Unsafe.SizeOf<T>() switch
    {
        //2 => Vec4<T>.From64(+value.AsVec64()), // any vector instructions for IEEE's binary16?
        4 => Vec4<T>.From128(+value.AsVec128()),
        8 => Vec4<T>.From256(+value.AsVec256()),
        _ => throw new NotSupportedException() // should it be even with guarantee of "IsHardware" and generic constraints? probably not
    } : SoftPlus(value);

    // all of next are pessimized

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> value) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(-value.AsVec128()),
        8 => Vec4<T>.From256(-value.AsVec256()),
    } : SoftNegate(value);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> vec, T value) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(vec.AsVec128() * value),
        8 => Vec4<T>.From256(vec.AsVec256() * value),
    } : SoftMultiply(vec, value);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> vec, T value) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(vec.AsVec128() / value),
        8 => Vec4<T>.From256(vec.AsVec256() / value),
    } : SoftDivide(vec, value);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator +(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(left.AsVec128() + right.AsVec128()),
        8 => Vec4<T>.From256(left.AsVec256() + right.AsVec256()),
    } : SoftAdd(left, right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator -(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(left.AsVec128() - right.AsVec128()),
        8 => Vec4<T>.From256(left.AsVec256() - right.AsVec256()),
    } : SoftSubtract(left, right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator *(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(left.AsVec128() * right.AsVec128()),
        8 => Vec4<T>.From256(left.AsVec256() * right.AsVec256()),
    } : SoftMultiply(left, right);

    [MethodImpl(AggressiveInlining)]
    public static Vec4<T> operator /(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(left.AsVec128() / right.AsVec128()),
        8 => Vec4<T>.From256(left.AsVec256() / right.AsVec256()),
    } : SoftMultiply(left, right);

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => left.AsVec128() == right.AsVec128(),
        8 => left.AsVec256() == right.AsVec256(),
    } : SoftEqual(left, right);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Vec4<T> left, Vec4<T> right) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => left.AsVec128() != right.AsVec128(),
        8 => left.AsVec256() != right.AsVec256(),
    } : SoftNotEqual(left, right);

    [MethodImpl(AggressiveInlining)]
    public readonly T Sum(Vec4<T> vec) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vector128.Sum(vec.AsVec128()),
        8 => Vector256.Sum(vec.AsVec256()),
    } : SoftSum(vec);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Abs() => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.Abs(AsVec128())),
        8 => Vec4<T>.From256(Vector256.Abs(AsVec256())),
    } : SoftAbs(this);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Min(Vec4<T> vec) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.Min(AsVec128(), vec.AsVec128())),
        8 => Vec4<T>.From256(Vector256.Min(AsVec256(), vec.AsVec256())),
    } : SoftMin(this, vec);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Max(Vec4<T> vec) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.Max(AsVec128(), vec.AsVec128())),
        8 => Vec4<T>.From256(Vector256.Max(AsVec256(), vec.AsVec256())),
    } : SoftMax(this, vec);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Clamp(Vec4<T> min, Vec4<T> max) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.Clamp(AsVec128(), min.AsVec128(), max.AsVec128())),
        8 => Vec4<T>.From256(Vector256.Clamp(AsVec256(), min.AsVec256(), max.AsVec256())),
    } : SoftClamp(this, min, max);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> Lerp(Vec4<T> vec, T amount) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.Lerp // maybe Lerp<T> including integers?
        (
            AsVec128F(),
            vec.AsVec128F(),
            Vector128.Create((float)(object)amount)
        )),
        8 => Vec4<T>.From256(Vector256.Lerp
        (
            AsVec256D(),
            vec.AsVec256D(),
            Vector256.Create((double)(object)amount)
        ))
    } : SoftLerp(this, vec, amount);

    [MethodImpl(AggressiveInlining)]
    public readonly Vec4<T> MultiplyAdd(Vec4<T> vec, Vec4<T> add) => Guard.IsHardware<T>() ? Unsafe.SizeOf<T>() switch
    {
        4 => Vec4<T>.From128(Vector128.MultiplyAddEstimate(AsVec128F(), vec.AsVec128F(), add.AsVec128F())),
        8 => Vec4<T>.From256(Vector256.MultiplyAddEstimate(AsVec256D(), vec.AsVec256D(), add.AsVec256D())),
    } : SoftMultiplyAdd(this, vec, add);
}
#pragma warning restore CS8509
