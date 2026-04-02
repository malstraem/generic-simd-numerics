namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007
public static class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromScale<T>(T value)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        return new(
            value,  T.Zero, T.Zero, T.Zero,
            T.Zero, value,  T.Zero, T.Zero,
            T.Zero, T.Zero, value,  T.Zero,
            T.Zero, T.Zero, T.Zero,  T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromScale<T>(Vec3<T> vec)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        return new(
            vec.X,  T.Zero, T.Zero, T.Zero,
            T.Zero, vec.Y,  T.Zero, T.Zero,
            T.Zero, T.Zero, vec.Z,  T.Zero,
            T.Zero, T.Zero, T.Zero,  T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromTranslation<T>(Vec3<T> vec)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        return new(
            T.One,  T.Zero, T.Zero, T.Zero,
            T.Zero, T.One,  T.Zero, T.Zero,
            T.Zero, T.Zero, T.One,  T.Zero,
            vec.X,  vec.Y,  vec.Z,  T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromQuat<T>(Quat<T> q)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        T two = T.One + T.One;

        T xx = q.X * q.X;
        T yy = q.Y * q.Y;
        T zz = q.Z * q.Z;

        T xy = q.X * q.Y;
        T zw = q.Z * q.W;
        T zx = q.Z * q.X;
        T yw = q.Y * q.W;
        T yz = q.Y * q.Z;
        T xw = q.X * q.W;

        return new(
            T.One - two * (yy + zz), two * (xy + zw),         two * (zx - yw),         T.Zero,
            two * (xy - zw),         T.One - two * (zz + xx), two * (yz + xw),         T.Zero,
            two * (zx + yw),         two * (yz - xw),         T.One - two * (yy + xx), T.Zero,
            T.Zero,                  T.Zero,                  T.Zero,                  T.One);

        /*if (typeof(T) == typeof(float))
        {
            var xmm1 = Vector128.Create((float)(object)yw, (float)(object)zw, (float)(object)(-yw), 0f);
            var xmm2 = Vector128.Create((float)(object)zx, (float)(object)xy, (float)(object)zx, 0f);

            var vec1 = xmm1 + xmm2;

            xmm1 = Vector128.Create((float)(object)(-zw), (float)(object)(-xw), (float)(object)xw, 0f);
            xmm2 = Vector128.Create((float)(object)xy, (float)(object)yz, (float)(object)yz, 0f);

            var vec2 = xmm1 + xmm2;

            xmm1 = Vector128.Create((float)(object)zz, (float)(object)zz, (float)(object)xx, 0f);
            xmm2 = Vector128.Create((float)(object)yy, (float)(object)xx, (float)(object)yy, 0f);

            var vec3 = xmm1 + xmm2;

            vec1 *= 2f;
            vec2 *= 2f;
            vec3 *= 2f;

            vec3 = Vector128.Create(1f) - vec3;

            var res1 = Vec4<T>.From128(vec1.As<float, T>());
            var res2 = Vec4<T>.From128(vec2.As<float, T>());
            var res3 = Vec4<T>.From128(vec3.As<float, T>());
            var res4 = Vec4<T>.From128(Vector128.Create(0f, 0f, 0f, 1f).As<float, T>());

            (res1.X, res3.X) = (res3.X, res1.X);
            (res2.Y, res3.Y) = (res3.Y, res2.Y);

            res3.W = T.Zero;

            return new(res1, res2, res3, res4);
        }*/

        /*SkipInit(out Vec4<T> shuffled);

        if (typeof(T) == typeof(float))
        {
            unsafe
            {
                Vector128.Store(Vector128.Shuffle(q.As128F(), Vector128.Create(1, 2, 3, 0)).As<float, T>(), (T*)&shuffled);
            }
        }
        else if (typeof(T) == typeof(double))
        {
            unsafe
            {
                Vector256.Store(Vector256.Shuffle(q.As256D(), Vector256.Create(1, 2, 3, 0)).As<double, T>(), (T*)&shuffled);
            }
        }
        else
        {
            shuffled.X = q.vec.Y;
            shuffled.Y = q.vec.Z;
            shuffled.Z = q.vec.W;
            shuffled.W = q.vec.X;
        }

        Vec4<T> square = q.vec * q.vec,
                multiply = q.vec * shuffled;

        T xz = q.Z * q.X,
          wy = q.Y * q.W;

        return new(
            T.One - two * (square.Y + square.Z), two * (multiply.X + multiply.Z),     two * (xz - wy),                     T.Zero,
            two * (multiply.X - multiply.Z),     T.One - two * (square.Z + square.X), two * (multiply.Y + multiply.W),     T.Zero,
            two * (xz + wy),                     two * (multiply.Y - multiply.W),     T.One - two * (square.Y + square.X), T.Zero,
            T.Zero,                              T.Zero,                              T.Zero,                              T.One);*/
    }
}
#pragma warning restore IDE0055, IDE0007
