namespace System.Numerics;

public static class Quat
{
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Add<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a + b;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Subtruct<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a - b;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> a, T n)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a * n;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a * b;

    [MethodImpl(AggressiveInlining)]
    public static T Dot<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a.Dot(b);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Divide<T>(Quat<T> a, Quat<T> b)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a / b;

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => q.Length();

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => q.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Normalize<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => q.Normalize();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Conjugate<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => q.Conjugate();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Inverse<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => q.Inverse();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Lerp<T>(Quat<T> a, Quat<T> b, T am)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => a.Lerp(b, am);

    [Obsolete("vectorize")]
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> AxisAngle<T>(Vec3<T> axis, T angle)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        var (s, c) = T.SinCos(angle * T.CreateChecked(0.5)); // T.Half should exist
        return new(axis * s, c);
    }

    [Obsolete("any way to vectorize?")]
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
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
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
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
