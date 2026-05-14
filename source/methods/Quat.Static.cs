namespace System.Numerics;

public static class Quat
{
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Add<T>(Quat<T> a, T n)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Add(a.Vec4(), n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Subtract<T>(Quat<T> a, T n)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Subtract(a.Vec4(), n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Add<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Add(a.Vec4(), b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Subtract<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Subtract(a.Vec4(), b.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> q, T n)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Multiply(q.Vec4(), n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Divide<T>(Quat<T> q, T n)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Divide(q.Vec4(), n).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector256.IsHardwareAccelerated))
        {
            return Quat<T>.Multiply(a, b);
        }
        var c = b * a.W;
        var d = b * a.X;
        var e = b * a.Y;
        var f = b * a.Z;

        return new(c.X + d.W + e.Z - f.Y,
                   c.Y - d.Z + e.W + f.X,
                   c.Z + d.Y - e.X + f.W,
                   c.W - d.X - e.Y - f.Z);
    }

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Divide<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Multiply(a, Inverse(b));

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Dot(a.Vec4(), b.Vec4());

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Length(q.Vec4());

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.LengthSquared(q.Vec4());

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Normalize<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => Vec4.Normalize(q.Vec4()).Quat();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Conjugate<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if ((SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
         || (SizeOf<T>() == 8 && Vector256<T>.IsSupported && Vector128.IsHardwareAccelerated))
        {
            return Quat<T>.Conjugate(q);
        }
        return new(-q.X, -q.Y, -q.Z, q.W);
    }

    [Obsolete("reciprocal?")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Inverse<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var ls = LengthSquared(q);

        if (SizeOf<T>() == 4 && Vector128<T>.IsSupported && Vector128.IsHardwareAccelerated)
        {
            var lsv = Vector128.Create(ls);

            var compare = Vector128.LessThanOrEqual(lsv, Vector128.Create(T.CreateChecked(1.192092896e-7f)));

            return Vector128.AndNot(Quat<T>.Conjugate(q).As128() / lsv, compare).Quat();
        }

        // todo 256 way with epsilon

        return Conjugate(q) * (T.One / ls);
    }

    [Obsolete("not sure")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Lerp<T>(Quat<T> a, Quat<T> b, T am)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var v = Vec4.Dot(a.Vec4(), b.Vec4()) >= T.Zero ? a.Vec4().Lerp(b.Vec4(), am)
                                                     : ((a.Vec4() * (T.One - am)) - (b.Vec4() * am));
        return Vec4.Normalize(v).Quat();
    }

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> AxisAngle<T>(Vec3<T> axis, T angle)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var (s, c) = T.SinCos(angle * T.CreateChecked(0.5)); // T.Half should exist
        return new(axis * s, c);
    }

    [Obsolete("any way to vectorize?")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Rotation<T>(Mat44<T> m)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T root, c, h = T.CreateChecked(0.5),

        b = m.X.X + m.Y.Y + m.Z.Z;

        if (b > T.Zero)
        {
            root = T.Sqrt(b + T.One); c = h / root;

            return new((m.Y.Z - m.Z.Y) * c,
                       (m.Z.X - m.X.Z) * c,
                       (m.X.Y - m.Y.X) * c,
                        root * h);
        }

        if (m.X.X >= m.Y.Y && m.X.X >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.X.X - m.Y.Y - m.Z.Z); c = h / root;

            return new(root * h,
                      (m.X.Y + m.Y.X) * c,
                      (m.X.Z + m.Z.X) * c,
                      (m.Y.Z - m.Z.Y) * c);
        }

        if (m.Y.Y >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.Y.Y - m.X.X - m.Z.Z); c = h / root;

            return new((m.Y.X + m.X.Y) * c,
                        root * h,
                       (m.Z.Y + m.Y.Z) * c,
                       (m.Z.X - m.X.Z) * c);
        }
        root = T.Sqrt(T.One + m.Z.Z - m.X.X - m.Y.Y); c = h / root;

        return new((m.Z.X + m.X.Z) * c,
                   (m.Z.Y + m.Y.Z) * c,
                    root * h,
                   (m.X.Y - m.Y.Z) * c);
    }

    [Obsolete("any way to vectorize?")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> YawPitchRoll<T>(T yaw, T pitch, T roll)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var h = T.CreateChecked(0.5);

        var (sr, cr) = T.SinCos(roll * h);
        var (sp, cp) = T.SinCos(pitch * h);
        var (sy, cy) = T.SinCos(yaw * h);

        return new((cy * sp * cr) + (sy * cp * sr),
                   (sy * cp * cr) - (cy * sp * sr),
                   (cy * cp * sr) - (sy * sp * cr),
                   (cy * cp * cr) + (sy * sp * sr));
    }
}
