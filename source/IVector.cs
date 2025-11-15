namespace System.Numerics;

public interface IVector<TSelf> where TSelf : IVector<TSelf>
{
    static abstract TSelf One { get; }
}
