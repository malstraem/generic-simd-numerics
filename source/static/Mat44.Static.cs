namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007
public static class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Affine128<T>(Vec3<T> pos, Quat<T> quat, Vec3<T> scale)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        unsafe
        {
            var qVec = quat.Vec4().As128();

            var xmm3 = qVec.WithElement(3, quat.Z);

            xmm3 *= qVec;

            var xmm4 = Vector128
                .Shuffle(quat.As128F(), Vector128.Create(3, 2, 0, 1))
                .As<float, T>();

            xmm4 *= qVec;

            T xy = quat.X * quat.Y;

            var xmm1 = Vector128.Create((float)(object)xmm4[2], (float)(object)xy, (float)(object)xmm4[1], 0f);
            var xmm2 = Vector128.Create((float)(object)xmm4[3], (float)(object)xmm3[3], (float)(object)xmm4[0], 0f);
            var vec1 = xmm1 + xmm2;
            var vec2 = xmm1 - xmm2;

            xmm1 = Vector128.Create((float)(object)xmm3[2], (float)(object)xmm3[2], (float)(object)xmm3[0], 0f);
            xmm2 = Vector128.Create((float)(object)xmm3[1], (float)(object)xmm3[0], (float)(object)xmm3[1], 0f);
            var vec3 = xmm1 + xmm2;

            vec1 *= 2f;
            vec2 *= 2f;
            vec3 *= 2f;
            vec3 = Vector128.Create(1f) - vec3;

            var res1 = Vector128.Create((float)(object)vec3[0], (float)(object)vec1[1], (float)(object)vec2[0], 0f).As<float, T>();
            var res2 = Vector128.Create((float)(object)vec2[1], (float)(object)vec3[1], (float)(object)vec1[2], 0f).As<float, T>();
            var res3 = Vector128.Create((float)(object)vec1[0], (float)(object)vec2[2], (float)(object)vec3[2], 0f).As<float, T>();

            SkipInit<Mat44<T>>(out var res);
            (res1 * Vector128.Create(scale.X)).Store((T*)&res.X);
            (res2 * Vector128.Create(scale.Y)).Store((T*)&res.Y);
            (res3 * Vector128.Create(scale.Z)).Store((T*)&res.Z);

            Vector128
                .CreateScalar(*(double*)&pos)
                .As<double, T>()
                .WithElement(2, pos.Z)
                .WithElement(3, T.One)
                .Store((T*)&res.W);

            return res;
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    private static Mat44<T> Affine256<T>(Vec3<T> pos, Quat<T> quat, Vec3<T> scale)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        unsafe
        {
            var qVec = quat.Vec4().As256();

            var xmm3 = qVec.WithElement(3, quat.Z);

            xmm3 *= qVec;

            var xmm4 = Vector256
                .Shuffle(quat.As256D(), Vector256.Create(3, 2, 0, 1))
                .As<double, T>();

            xmm4 *= qVec;

            T xy = quat.X * quat.Y;

            var xmm1 = Vector256.Create((double)(object)xmm4[2], (double)(object)xy, (double)(object)xmm4[1], 0f);
            var xmm2 = Vector256.Create((double)(object)xmm4[3], (double)(object)xmm3[3], (double)(object)xmm4[0], 0f);
            var vec1 = xmm1 + xmm2;
            var vec2 = xmm1 - xmm2;

            xmm1 = Vector256.Create((double)(object)xmm3[2], (double)(object)xmm3[2], (double)(object)xmm3[0], 0f);
            xmm2 = Vector256.Create((double)(object)xmm3[1], (double)(object)xmm3[0], (double)(object)xmm3[1], 0f);
            var vec3 = xmm1 + xmm2;

            vec1 *= 2f;
            vec2 *= 2f;
            vec3 *= 2f;
            vec3 = Vector256.Create(1.0) - vec3;

            var res1 = Vector256.Create((double)(object)vec3[0], (double)(object)vec1[1], (double)(object)vec2[0], 0f).As<double, T>();
            var res2 = Vector256.Create((double)(object)vec2[1], (double)(object)vec3[1], (double)(object)vec1[2], 0f).As<double, T>();
            var res3 = Vector256.Create((double)(object)vec1[0], (double)(object)vec2[2], (double)(object)vec3[2], 0f).As<double, T>();

            SkipInit<Mat44<T>>(out var res);
            (res1 * Vector256.Create(scale.X)).Store((T*)&res.X);
            (res2 * Vector256.Create(scale.Y)).Store((T*)&res.Y);
            (res3 * Vector256.Create(scale.Z)).Store((T*)&res.Z);

            Vector256
                .Create((double)(object)pos.X, (double)(object)pos.Y, (double)(object)pos.Z, 1f)
                .As<double, T>()
                .Store((T*)&res.W);

            return res;
        }
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Affine<T>(Vec3<T> t, Quat<T> r, Vec3<T> s)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        if (typeof(T) == typeof(float) && Vector128<float>.IsSupported)
            return Affine128(t, r, s);

        if (typeof(T) == typeof(double) && Vector256<double>.IsSupported)
            return Affine256(t, r, s);

        T d = T.One + T.One, // T.Two should exist

        xx = r.X * r.X,
        yy = r.Y * r.Y,
        zz = r.Z * r.Z,
        xy = r.X * r.Y,
        zw = r.Z * r.W,
        zx = r.Z * r.X,
        yw = r.Y * r.W,
        yz = r.Y * r.Z,
        xw = r.X * r.W;

        Vec4<T>
        x = new(T.One - (d * (yy + zz)), d * (xy + zw),           d * (zx - yw),           T.Zero),
        y = new(d * (xy - zw),           T.One - (d * (zz + xx)), d * (yz + xw),           T.Zero),
        z = new(d * (zx + yw),           d * (yz - xw),           T.One - (d * (yy + xx)), T.Zero),
        w = new(t.X,                     t.Y,                     t.Z,                     T.One);

        return new(x * s.X, y * s.Y, z * s.Z, w);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Transform<T>(Mat44<T> m, Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T xx = q.X * q.X,
          yy = q.Y * q.Y,
          zz = q.Z * q.Z,
          xy = q.X * q.Y,
          zw = q.Z * q.W,
          zx = q.Z * q.X,
          yw = q.Y * q.W,
          yz = q.Y * q.Z,
          xw = q.X * q.W;

        T d = T.One + T.One;

        T q11 = T.One - d * (yy + zz),
          q12 = d * (xy + zw),
          q13 = d * (zx - yw),
          q21 = d * (xy - zw),
          q22 = T.One - d * (zz + xx),
          q23 = d * (yz + xw),
          q31 = d * (zx + yw),
          q32 = d * (yz - xw),
          q33 = T.One - d * (yy + xx);

        return new(
            new(m.X.X * q11 + m.X.Y * q21 + m.X.Z * q31,
                m.X.X * q12 + m.X.Y * q22 + m.X.Z * q32,
                m.X.X * q13 + m.X.Y * q23 + m.X.Z * q33,
                m.X.W),

            new(m.Y.X * q11 + m.Y.Y * q21 + m.Y.Z * q31,
                m.Y.X * q12 + m.Y.Y * q22 + m.Y.Z * q32,
                m.Y.X * q13 + m.Y.Y * q23 + m.Y.Z * q33,
                m.Y.W),

            new(m.Z.X * q11 + m.Z.Y * q21 + m.Z.Z * q31,
                m.Z.X * q12 + m.Z.Y * q22 + m.Z.Z * q32,
                m.Z.X * q13 + m.Z.Y * q23 + m.Z.Z * q33,
                m.Z.W),

            new(m.W.X * q11 + m.W.Y * q21 + m.W.Z * q31,
                m.W.X * q12 + m.W.Y * q22 + m.W.Z * q32,
                m.W.X * q13 + m.W.Y * q23 + m.W.Z * q33,
                m.W.W));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(T s)
        where T : unmanaged, INumber<T>
            => new(s,      T.Zero, T.Zero, T.Zero,
                   T.Zero, s,      T.Zero, T.Zero,
                   T.Zero, T.Zero, s,      T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Scale<T>(Vec3<T> s)
        where T : unmanaged, INumber<T>
            => new(s.X,    T.Zero, T.Zero, T.Zero,
                   T.Zero, s.Y,    T.Zero, T.Zero,
                   T.Zero, T.Zero, s.Z,    T.Zero,
                   T.Zero, T.Zero, T.Zero, T.One);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Translation<T>(Vec3<T> v)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
            => new(T.One,  T.Zero, T.Zero, T.Zero,
                   T.Zero, T.One,  T.Zero, T.Zero,
                   T.Zero, T.Zero, T.One,  T.Zero,
                   v.X,    v.Y,    v.Z,    T.One);

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Rotation<T>(Quat<T> q)
        where T : unmanaged, INumber<T>, IRootFunctions<T>, ITrigonometricFunctions<T>
    {
        T d = T.One + T.One;

        T xx = q.X * q.X,
          yy = q.Y * q.Y,
          zz = q.Z * q.Z,
          xy = q.X * q.Y,
          zw = q.Z * q.W,
          zx = q.Z * q.X,
          yw = q.Y * q.W,
          yz = q.Y * q.Z,
          xw = q.X * q.W;

        return new(T.One - d * (yy + zz), d * (xy + zw),         d * (zx - yw),         T.Zero,
                   d * (xy - zw),         T.One - d * (zz + xx), d * (yz + xw),         T.Zero,
                   d * (zx + yw),         d * (yz - xw),         T.One - d * (yy + xx), T.Zero,
                   T.Zero,                T.Zero,                T.Zero,                T.One);
    }
}
