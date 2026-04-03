namespace System.Numerics;

public static class Quat
{
    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Add<T>(Quat<T> left, Quat<T> right)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left + right;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Substruct<T>(Quat<T> left, Quat<T> right)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left - right;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> left, T num)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left * num;

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Multiply<T>(Quat<T> left, Quat<T> right)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left * right;

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static T Dot<T>(Quat<T> left, Quat<T> right)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left.Dot(right);

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Divide<T>(Quat<T> left, Quat<T> right)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left / right;

    [MethodImpl(AggressiveInlining)]
    public static T Length<T>(Quat<T> quat)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => quat.Length();

    [MethodImpl(AggressiveInlining)]
    public static T LengthSquared<T>(Quat<T> quat)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => quat.LengthSquared();

    [MethodImpl(AggressiveInlining)]
    public static Quat<T> Normalize<T>(Quat<T> quat)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => quat.Normalize();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Conjugate<T>(Quat<T> quat)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => quat.Conjugate();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Inverse<T>(Quat<T> quat)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => quat.Inverse();

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Lerp<T>(Quat<T> left, Quat<T> right, T amount)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
            => left.Lerp(right, amount);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> AxisAngle<T>(Vec3<T> axis, T angle)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        var (s, c) = T.SinCos(angle * T.CreateChecked(0.5));
        return new(axis * s, c);
    }

    // any way to vectorize?
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> Rotation<T>(Mat44<T> m)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        T root, c, h = T.CreateChecked(0.5), d = T.CreateChecked(2d),

        b = m.X.X + m.Y.Y + m.Z.Z;

        if (b > T.Zero)
        {
            root = T.Sqrt(b + T.One); c = T.One / (root * d);

            return new((m.Y.Z - m.Z.Y) * c,
                       (m.Z.X - m.X.Z) * c,
                       (m.X.Y - m.Y.X) * c,
                        root * h);
        }

        if (m.X.X >= m.Y.Y && m.X.X >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.X.X - m.Y.Y - m.Z.Z); c = T.One / (root * d);

            return new(root * h,
                      (m.X.Y + m.Y.X) * c,
                      (m.X.Z + m.Z.X) * c,
                      (m.Y.Z - m.Z.Y) * c);
        }

        if (m.Y.Y >= m.Z.Z)
        {
            root = T.Sqrt(T.One + m.Y.Y - m.X.X - m.Z.Z); c = T.One / (root * d);

            return new((m.Y.X + m.X.Y) * c,
                        root * h,
                       (m.Z.Y + m.Y.Z) * c,
                       (m.Z.X - m.X.Z) * c);
        }
        root = T.Sqrt(T.One + m.Z.Z - m.X.X - m.Y.Y); c = T.One / (root * d);

        return new((m.Z.X + m.X.Z) * c,
                   (m.Z.Y + m.Y.Z) * c,
                    root * h,
                   (m.X.Y - m.Y.Z) * c);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Quat<T> YawPitchRoll<T>(T yaw, T pitch, T roll)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
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
