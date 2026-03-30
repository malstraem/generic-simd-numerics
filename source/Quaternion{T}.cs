using System.Globalization;
using System.Numerics;

namespace GenericNumerics;

public partial struct Quat<T>
    where T : unmanaged, ITrigonometricFunctions<T>, IRootFunctions<T>, INumber<T>
{
    private static readonly T two = T.One + T.One;

    public T X;

    public T Y;

    public T Z;

    public T W;

    public Quat(T x, T y, T z, T w)
    {
        X = x;
        Y = y;
        Z = z;
        W = w;
    }

    /// <summary>Constructs a Quaternion from the given vector and rotation parts.</summary>
    /// <param name="vec">The vector part of the Quaternion.</param>
    /// <param name="w">The rotation part of the Quaternion.</param>
    public Quat(Vec3<T> vec, T w)
    {
        X = vec.X;
        Y = vec.Y;
        Z = vec.Z;
        W = w;
    }

    /// <summary>Returns a Quaternion representing no rotation.</summary>
    public static Quat<T> Identity => new(T.Zero, T.Zero, T.Zero, T.One);

    public readonly bool IsIdentity => this == Identity;

    /// <summary>Adds two Quaternions element-by-element.</summary>
    /// <param name="value1">The first source Quaternion.</param>
    /// <param name="value2">The second source Quaternion.</param>
    /// <returns>The result of adding the Quaternions.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> operator +(Quat<T> value1, Quat<T> value2)
        => Quat<T>.FromVec4(value1.AsVec4() + value2.AsVec4());

    /// <summary>Divides a Quaternion by another Quaternion.</summary>
    /// <param name="value1">The source Quaternion.</param>
    /// <param name="value2">The divisor.</param>
    /// <returns>The result of the division.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> operator /(Quat<T> value1, Quat<T> value2)
        => value1 * Quat<T>.Inverse(value2);

    /// <summary>Returns a boolean indicating whether the two given Quaternions are equal.</summary>
    /// <param name="value1">The first Quaternion to compare.</param>
    /// <param name="value2">The second Quaternion to compare.</param>
    /// <returns>True if the Quaternions are equal; False otherwise.</returns>
    public static bool operator ==(Quat<T> value1, Quat<T> value2)
        => value1.X == value2.X
        && value1.Y == value2.Y
        && value1.Z == value2.Z
        && value1.W == value2.W;

    /// <summary>Returns a boolean indicating whether the two given Quaternions are not equal.</summary>
    /// <param name="value1">The first Quaternion to compare.</param>
    /// <param name="value2">The second Quaternion to compare.</param>
    /// <returns>True if the Quaternions are not equal; False if they are equal.</returns>
    public static bool operator !=(Quat<T> value1, Quat<T> value2)
        => value1.X != value2.X
        || value1.Y != value2.Y
        || value1.Z != value2.Z
        || value1.W != value2.W;

    /// <summary>Multiplies two Quaternions together.</summary>
    /// <param name="left">The Quaternion on the left side of the multiplication.</param>
    /// <param name="right">The Quaternion on the right side of the multiplication.</param>
    /// <returns>The result of the multiplication.</returns>
    public static Quat<T> operator *(Quat<T> left, Quat<T> right)
    {
        return new(
            left.W * right.X + left.X * right.W + left.Y * right.Z - left.Z * right.Y,
            left.W * right.Y - left.X * right.Z + left.Y * right.W + left.Z * right.X,
            left.W * right.Z + left.X * right.Y - left.Y * right.X + left.Z * right.W,
            left.W * right.W - left.X * right.X - left.Y * right.Y - left.Z * right.Z);
    }

    /// <summary>Multiplies a Quaternion by a scalar value.</summary>
    /// <param name="value1">The source Quaternion.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The result of the multiplication.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> operator *(Quat<T> value1, T value2)
        => Quat<T>.FromVec4(value1.AsVec4() * value2);

    /// <summary>Subtracts one Quaternion from another.</summary>
    /// <param name="value1">The first source Quaternion.</param>
    /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
    /// <returns>The result of the subtraction.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> operator -(Quat<T> value1, Quat<T> value2)
        => Quat<T>.FromVec4(value1.AsVec4() - value2.AsVec4());

    /// <summary>Flips the sign of each component of the quaternion.</summary>
    /// <param name="value">The source Quaternion.</param>
    /// <returns>The negated Quaternion.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> operator -(Quat<T> value) => new(-value.X, -value.Y, -value.Z, -value.W);

    /// <summary>Adds two Quaternions element-by-element.</summary>
    /// <param name="value1">The first source Quaternion.</param>
    /// <param name="value2">The second source Quaternion.</param>
    /// <returns>The result of adding the Quaternions.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Add(Quat<T> value1, Quat<T> value2) => value1 + value2;

    /// <summary>Creates the conjugate of a specified Quaternion.</summary>
    /// <param name="value">The Quaternion of which to return the conjugate.</param>
    /// <returns>A new Quaternion that is the conjugate of the specified one.</returns>
    public static Quat<T> Conjugate(Quat<T> value) => new(-value.X, -value.Y, -value.Z, value.W);

    /// <summary>Creates a Quaternion from a normalized vector axis and an angle to rotate about the vector.</summary>
    /// <param name="axis">The unit vector to rotate around.
    /// This vector must be normalized before calling this function or the resulting Quaternion will be incorrect.</param>
    /// <param name="angle">The angle, in radians, to rotate around the vector.</param>
    /// <returns>The created Quaternion.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> CreateFromAxisAngle(Vec3<T> axis, T angle)
    {
        var (s, c) = T.SinCos(angle / two);
        return new(axis * s, c);
    }

    /// <summary>Creates a Quaternion from the given rotation matrix.</summary>
    /// <param name="matrix">The rotation matrix.</param>
    /// <returns>The created Quaternion.</returns>
    public static Quat<T> CreateFromRotationMatrix(Mat44<T> matrix)
    {
        var trace = matrix.X.X + matrix.Y.Y + matrix.Z.Z;

        T s, invS;

        if (trace > T.Zero)
        {
            s = T.Sqrt(trace + T.One);
            invS = T.One / (two * s);

            return new(
                (matrix.Y.Z - matrix.Z.Y) * invS,
                (matrix.Z.X - matrix.X.Z) * invS,
                (matrix.X.Y - matrix.Y.X) * invS,
                s / two);
        }

        if (matrix.X.X >= matrix.Y.Y && matrix.X.X >= matrix.Z.Z)
        {
            s = T.Sqrt(T.One + matrix.X.X - matrix.Y.Y - matrix.Z.Z);
            invS = T.One / (two * s);

            return new(
                s / two,
                (matrix.X.Y + matrix.Y.X) * invS,
                (matrix.X.Z + matrix.Z.X) * invS,
                (matrix.Y.Z - matrix.Z.Y) * invS);
        }

        if (matrix.Y.Y >= matrix.Z.Z)
        {
            s = T.Sqrt(T.One + matrix.Y.Y - matrix.X.X - matrix.Z.Z);
            invS = T.One / (two * s);

            return new(
                (matrix.Y.X + matrix.X.Y) * invS,
                s / two,
                (matrix.Z.Y + matrix.Y.Z) * invS,
                (matrix.Z.X - matrix.X.Z) * invS);
        }

        s = T.Sqrt(T.One + matrix.Z.Z - matrix.X.X - matrix.Y.Y);
        invS = T.One / (two * s);

        return new(
            (matrix.Z.X + matrix.X.Z) * invS,
            (matrix.Z.Y + matrix.Y.Z) * invS,
            s / two,
            (matrix.X.Y - matrix.Y.Z) * invS);
    }

    /// <summary>Creates a new Quaternion from the given yaw, pitch, and roll, in radians.</summary>
    /// <param name="yaw">The yaw angle, in radians, around the Y-axis.</param>
    /// <param name="pitch">The pitch angle, in radians, around the X-axis.</param>
    /// <param name="roll">The roll angle, in radians, around the Z-axis.</param>
    /// <returns></returns>
    public static Quat<T> CreateFromYawPitchRoll(T yaw, T pitch, T roll)
    {
        //  Roll first, about axis the object is facing, then
        //  pitch upward, then yaw to face into the new heading
        var (sr, cr) = T.SinCos(roll / two);
        var (sp, cp) = T.SinCos(pitch / two);
        var (sy, cy) = T.SinCos(yaw / two);

        return new(
            cy * sp * cr + sy * cp * sr,
            sy * cp * cr - cy * sp * sr,
            cy * cp * sr - sy * sp * cr,
            cy * cp * cr + sy * sp * sr);
    }

    /// <summary>Divides a Quaternion by another Quaternion.</summary>
    /// <param name="value1">The source Quaternion.</param>
    /// <param name="value2">The divisor.</param>
    /// <returns>The result of the division.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Divide(Quat<T> value1, Quat<T> value2) => value1 / value2;

    /// <summary>Calculates the dot product of two Quaternions.</summary>
    /// <param name="quaternion1">The first source Quaternion.</param>
    /// <param name="quaternion2">The second source Quaternion.</param>
    /// <returns>The dot product of the Quaternions.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static T Dot(Quat<T> value1, Quat<T> value2) => Vec4<T>.Dot(value1.AsVec4(), value2.AsVec4());

    /// <summary>Returns the inverse of a Quaternion.</summary>
    /// <param name="value">The source Quaternion.</param>
    /// <returns>The inverted Quaternion.</returns>
    //  -1   (       a              -v       )
    // q   = ( -------------   ------------- )
    //       (  a^2 + |v|^2  ,  a^2 + |v|^2  )
    public static Quat<T> Inverse(Quat<T> value)
        => Quat<T>.FromVec4(Quat<T>.Conjugate(value).AsVec4() / value.LengthSquared());

    /// <summary> Linearly interpolates between two quaternions.</summary>
    /// <param name="value1">The first source Quaternion.</param>
    /// <param name="value2">The second source Quaternion.</param>
    /// <param name="amount">The relative weight of the second source Quaternion in the interpolation.</param>
    /// <returns>The interpolated Quaternion.</returns>
    public static Quat<T> Lerp(Quat<T> value1, Quat<T> value2, T amount)
    {
        if (Quat<T>.Dot(value1, value2) >= T.Zero)
            return Normalize(Quat<T>.FromVec4(Vec4<T>.Lerp(value1.AsVec4(), value2.AsVec4(), amount)));

        T t = amount, t1 = T.One - t;

        return Normalize(new(
            t1 * value1.X - t * value2.X,
            t1 * value1.Y - t * value2.Y,
            t1 * value1.Z - t * value2.Z,
            t1 * value1.W - t * value2.W));
    }

    /// <summary>Multiplies two Quaternions together.</summary>
    /// <param name="value1">The Quaternion on the left side of the multiplication.</param>
    /// <param name="value2">The Quaternion on the right side of the multiplication.</param>
    /// <returns>The result of the multiplication.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Multiply(Quat<T> value1, Quat<T> value2) => value1 * value2;

    /// <summary>Multiplies a Quaternion by a scalar value.</summary>
    /// <param name="value1">The source Quaternion.</param>
    /// <param name="value2">The scalar value.</param>
    /// <returns>The result of the multiplication.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Multiply(Quat<T> value1, T value2) => value1 * value2;

    /// <summary>Flips the sign of each component of the quaternion.</summary>
    /// <param name="value">The source Quaternion.</param>
    /// <returns>The negated Quaternion.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Negate(Quat<T> value) => -value;

    /// <summary>Divides each component of the Quaternion by the length of the Quaternion.</summary>
    /// <param name="value">The source Quaternion.</param>
    /// <returns>The normalized Quaternion.</returns>
    public static Quat<T> Normalize(Quat<T> value)
            => Quat<T>.FromVec4(value.AsVec4().Normalize());

    /// <summary>Subtracts one Quaternion from another.</summary>
    /// <param name="value1">The first source Quaternion.</param>
    /// <param name="value2">The second Quaternion, to be subtracted from the first.</param>
    /// <returns>The result of the subtraction.</returns>
    [MethodImpl((MethodImplOptions)768)]
    public static Quat<T> Subtract(Quat<T> value1, Quat<T> value2) => value1 - value2;

    /// <summary>Returns a boolean indicating whether the given Object is equal to this Quaternion instance.</summary>
    /// <param name="obj">The Object to compare against.</param>
    /// <returns>True if the Object is equal to this Quaternion; False otherwise.</returns>
    public override readonly bool Equals(object? obj) => (obj is Quat<T> other) && Equals(other);

    /// <summary>Returns a boolean indicating whether the given Quaternion is equal to this Quaternion instance.</summary>
    /// <param name="other">The Quaternion to compare this instance to.</param>
    /// <returns>True if the other Quaternion is equal to this instance; False otherwise.</returns>
    public readonly bool Equals(Quat<T> other) => this == other;

    /// <summary>Returns the hash code for this instance.</summary>
    /// <returns>The hash code.</returns>
    public override readonly int GetHashCode()
        => unchecked(X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode());

    /// <summary>Calculates the length of the Quaternion.</summary>
    /// <returns>The computed length of the Quaternion.</returns>
    public readonly T Length() => AsVec4().Length();

    /// <summary>Calculates the length squared of the Quaternion. This operation is cheaper than Length().</summary>
    /// <returns>The length squared of the Quaternion.</returns>
    public readonly T LengthSquared() => AsVec4().LengthSquared();

    /// <summary>Returns a String representing this Quaternion instance.</summary>
    /// <returns>The string representation.</returns>
    public override readonly string ToString()
        => string.Format(CultureInfo.CurrentCulture, "{{X:{0} Y:{1} Z:{2} W:{3}}}", X, Y, Z, W);
}
