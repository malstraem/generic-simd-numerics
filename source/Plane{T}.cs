namespace System.Numerics;

[StructLayout(LayoutKind.Sequential)]
public partial struct Plane<T>(Vec3<T> normal, T distance)
    where T : unmanaged, INumber<T>
{
    public Vec3<T> Normal = normal;

    public T Distance = distance;

    public Plane(T x, T y, T z, T d) : this(new(x, y, z), d) { }

    //public readonly bool Equals(Plane<T> other) => this == other;

    //public override readonly bool Equals(object? obj) => (obj is Plane<T> other) && this == other;

    //public override readonly int GetHashCode() => HashCode.Combine(X, Y, Z, W);

    public override readonly string ToString() => $"(n: {Normal}, d: {Distance})";
}
