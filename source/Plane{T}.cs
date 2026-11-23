namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Plane<T>(Vec3<T> normal, T distance) : IEquatable<Plane<T>>
    where T : unmanaged, IFloatingPoint<T>, IRootFunctions<T>
{
    public Vec3<T> Normal = normal;

    public T Distance = distance;

    public Plane(T x, T y, T z, T d) : this(new(x, y, z), d) { }

    [MethodImpl(AggressiveInlining)]
    public static bool operator ==(Plane<T> a, Plane<T> b) => Planes.Equal(a, b);

    [MethodImpl(AggressiveInlining)]
    public static bool operator !=(Plane<T> a, Plane<T> b) => Planes.NotEqual(a, b);

    [MethodImpl(AggressiveInlining)]
    public readonly T Dot(Vec4<T> v) => Planes.Dot(this, v);

    public readonly bool Equals(Plane<T> other) => this == other;

    public override readonly bool Equals(object? obj) => (obj is Plane<T> other) && this == other;

    public override readonly int GetHashCode() => this.Vec4().GetHashCode();

    public override readonly string ToString() => $"[n: {Normal}, d: {Distance}]";
}
