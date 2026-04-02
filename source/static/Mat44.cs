namespace System.Numerics;

public static class Mat44
{
#pragma warning disable IDE0007
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromQuat<T>(Quat<T> q)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        T two = T.One + T.One;

        T xx = q.X * q.X;
        T yy = q.Y * q.Y;
        T zz = q.Z * q.Z;

        T xy = q.X * q.Y;
        T wz = q.Z * q.W;
        T xz = q.Z * q.X;
        T wy = q.Y * q.W;
        T yz = q.Y * q.Z;
        T wx = q.X * q.W;

        return new(
            T.One - two * (yy + zz), two * (xy + wz), two * (xz - wy), T.Zero,
            two * (xy - wz), T.One - two * (zz + xx), two * (yz + wx), T.Zero,
            two * (xz + wy), two * (yz - wx), T.One - two * (yy + xx), T.Zero,
            T.Zero, T.Zero, T.Zero, T.One);

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
#pragma warning restore IDE0007
}
