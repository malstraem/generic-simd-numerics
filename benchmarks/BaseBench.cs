namespace System.Numerics.Bench;

public abstract class BaseBench
{
    public static T Add<T>(T[] vectors) where T : IVector<T>, IAdditionOperators<T, T, T>
    {
        var res = T.One;

        foreach (var vec in vectors)
            res += vec;

        return res;
    }

    public static T Substract<T>(T[] vectors) where T : IVector<T>, ISubtractionOperators<T, T, T>
    {
        var res = T.One;

        foreach (var vec in vectors)
            res -= vec;

        return res;
    }

    public static T Multiply<T>(T[] vectors) where T : IVector<T>, IMultiplyOperators<T, T, T>
    {
        var res = T.One;

        foreach (var vec in vectors)
            res *= vec;

        return res;
    }

    public static T Divide<T>(T[] vectors) where T : IVector<T>, IDivisionOperators<T, T, T>
    {
        var res = T.One;

        foreach (var vec in vectors)
            res /= vec;

        return res;
    }
}
