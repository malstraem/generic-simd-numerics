namespace System.Numerics;

#pragma warning disable IDE0055, IDE0007
public static class Mat44
{
    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> FromTranslationRotationScale<T>(Vec3<T> pos, Quat<T> quat, Vec3<T> scale)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        T xx = quat.X * quat.X,
          yy = quat.Y * quat.Y,
          zz = quat.Z * quat.Z,
          xy = quat.X * quat.Y,
          zw = quat.Z * quat.W,
          zx = quat.Z * quat.X,
          yw = quat.Y * quat.W,
          yz = quat.Y * quat.Z,
          xw = quat.X * quat.W;

        if (typeof(T) == typeof(float))
        {
            unsafe
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
                var res3 = Vec4<T>
                    .From128(
                        Vector128
                            .CreateScalar(*(double*)&vec3)
                            .As<double, T>()
                            .WithElement(2, (T)(object)vec3[2])
                            .WithElement(3, T.Zero)
                            );

                (res1.X, res3.X) = (res3.X, res1.X);
                (res2.Y, res3.Y) = (res3.Y, res2.Y);

                SkipInit<Mat44<T>>(out var res);

                (res1.As128() * Vector128.Create(scale.X)).Store((T*)&res.X);
                (res2.As128() * Vector128.Create(scale.Y)).Store((T*)&res.Y);
                (res3.As128() * Vector128.Create(scale.Z)).Store((T*)&res.Z);
                
                Vector128
                    .CreateScalar(*(double*)&pos)
                    .As<double, T>()
                    .WithElement(2, pos.Z)
                    .WithElement(3, T.One)
                    .Store((T*)&res.W);

                return res;
            }
        }

        T two = T.One + T.One;

        Vec4<T> v1 = new(T.One - two * (yy + zz), two * (xy + zw), two * (zx - yw), T.Zero),
                v2 = new(two * (xy - zw), T.One - two * (zz + xx), two * (yz + xw), T.Zero),
                v3 = new(two * (zx + yw), two * (yz - xw), T.One - two * (yy + xx), T.Zero);

        return new(v1 * scale.X, v2 * scale.Y, v3 * scale.Z, new(pos.X, pos.Y, pos.Z, T.One));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> Transfrom<T>(Mat44<T> mat, Quat<T> q)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
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

        /*if (typeof(T) == typeof(float))
        {
            unsafe
            {
                var lastCol = (mat.X.W, mat.Y.W, mat.Z.W, mat.W.W);

                var vec1 = Vector128.Create((float)(object)yw, (float)(object)zw, (float)(object)-yw, 0f)
                         + Vector128.Create((float)(object)zx, (float)(object)xy, (float)(object)zx, 0f);

                var vec2 = Vector128.Create((float)(object)-zw, (float)(object)-xw, (float)(object)xw, 0f)
                         + Vector128.Create((float)(object)xy, (float)(object)yz, (float)(object)yz, 0f);

                var vec3 = Vector128.Create((float)(object)zz, (float)(object)zz, (float)(object)xx, 0f)
                         + Vector128.Create((float)(object)yy, (float)(object)xx, (float)(object)yy, 0f);

                vec1 *= 2f;
                vec2 *= 2f;
                vec3 *= 2f;

                vec3 = Vector128.Create(1f) - vec3;

                float temp0 = vec1[0], temp1 = vec3[1];

                var xmm1 = vec1.WithElement(0, vec3[0]);

                var xmm3 = Vector128.Create(temp0, vec2[1], vec3[2], 0);

                var xmm2 = vec2.WithElement(1, temp1);

                var xmm4 = Vector128.Create((float)(object)mat.X.X) * xmm1;

                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.X.Y), xmm2, xmm4);
                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.X.Z), xmm3, xmm4);

                Vector128.Store(xmm4.As<float, T>(), (T*)&mat.X);

                xmm4 = Vector128.Create((float)(object)mat.Y.X) * xmm1;

                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.Y.Y), xmm2, xmm4);
                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.Y.Z), xmm3, xmm4);

                Vector128.Store(xmm4.As<float, T>(), (T*)&mat.Y);

                xmm4 = Vector128.Create((float)(object)mat.Z.X) * xmm1;

                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.Z.Y), xmm2, xmm4);
                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.Z.Z), xmm3, xmm4);

                Vector128.Store(xmm4.As<float, T>(), (T*)&mat.Z);

                xmm4 = Vector128.Create((float)(object)mat.W.X) * xmm1;

                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.W.Y), xmm2, xmm4);
                xmm4 = Vector128.MultiplyAddEstimate(Vector128.Create((float)(object)mat.W.Z), xmm3, xmm4);

                Vector128.Store(xmm4.As<float, T>(), (T*)&mat.W);

                (mat.X.W, mat.Y.W, mat.Z.W, mat.W.W) = lastCol;
            }

            return mat;
        }*/

        T two = T.One + T.One;

        T q11 = T.One - two * (yy + zz),
          q12 = two * (xy + zw),
          q13 = two * (zx - yw),
          q21 = two * (xy - zw),
          q22 = T.One - two * (zz + xx),
          q23 = two * (yz + xw),
          q31 = two * (zx + yw),
          q32 = two * (yz - xw),
          q33 = T.One - two * (yy + xx);

        return new(
            new(
                mat.X.X * q11 + mat.X.Y * q21 + mat.X.Z * q31,
                mat.X.X * q12 + mat.X.Y * q22 + mat.X.Z * q32,
                mat.X.X * q13 + mat.X.Y * q23 + mat.X.Z * q33,
                mat.X.W),
            new(
                mat.Y.X * q11 + mat.Y.Y * q21 + mat.Y.Z * q31,
                mat.Y.X * q12 + mat.Y.Y * q22 + mat.Y.Z * q32,
                mat.Y.X * q13 + mat.Y.Y * q23 + mat.Y.Z * q33,
                mat.Y.W),
            new(
                mat.Z.X * q11 + mat.Z.Y * q21 + mat.Z.Z * q31,
                mat.Z.X * q12 + mat.Z.Y * q22 + mat.Z.Z * q32,
                mat.Z.X * q13 + mat.Z.Y * q23 + mat.Z.Z * q33,
                mat.Z.W),
            new(
                mat.W.X * q11 + mat.W.Y * q21 + mat.W.Z * q31,
                mat.W.X * q12 + mat.W.Y * q22 + mat.W.Z * q32,
                mat.W.X * q13 + mat.W.Y * q23 + mat.W.Z * q33,
                mat.W.W));
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromScale<T>(T value)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        return new(
            value,  T.Zero, T.Zero, T.Zero,
            T.Zero, value,  T.Zero, T.Zero,
            T.Zero, T.Zero, value,  T.Zero,
            T.Zero, T.Zero, T.Zero, T.One);
    }

    [MethodImpl(AggressiveInlining | AggressiveOptimization)]
    public static Mat44<T> CreateFromScale<T>(Vec3<T> vec)
        where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
    {
        return new(
            vec.X,  T.Zero, T.Zero, T.Zero,
            T.Zero, vec.Y,  T.Zero, T.Zero,
            T.Zero, T.Zero, vec.Z,  T.Zero,
            T.Zero, T.Zero, T.Zero, T.One);
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

        T xx = q.X * q.X,
          yy = q.Y * q.Y,
          zz = q.Z * q.Z,
          xy = q.X * q.Y,
          zw = q.Z * q.W,
          zx = q.Z * q.X,
          yw = q.Y * q.W,
          yz = q.Y * q.Z,
          xw = q.X * q.W;

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
