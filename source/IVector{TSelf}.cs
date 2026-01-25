namespace System.Numerics;

// shitty?

public interface IVector<TSelf> :
    IAdditiveIdentity<TSelf, TSelf>,
    IMultiplicativeIdentity<TSelf, TSelf>
        where TSelf : IVector<TSelf>
{
    static abstract TSelf Zero { get; }

    static abstract TSelf One { get; }
}

public interface IVectorOperators<TSelf> :
    IAdditionOperators<TSelf, TSelf, TSelf>,
    ISubtractionOperators<TSelf, TSelf, TSelf>,
    IMultiplyOperators<TSelf, TSelf, TSelf>,
    IDivisionOperators<TSelf, TSelf, TSelf>,
    IUnaryNegationOperators<TSelf, TSelf>,
    IUnaryPlusOperators<TSelf, TSelf>
        where TSelf : IVector<TSelf>, IVectorOperators<TSelf>;

public interface IVectorScalarOperators<TSelf, TScalar> :
    IAdditionOperators<TSelf, TScalar, TSelf>,
    ISubtractionOperators<TSelf, TScalar, TSelf>,
    IMultiplyOperators<TSelf, TScalar, TSelf>,
    IDivisionOperators<TSelf, TScalar, TSelf>
        where TSelf : IVector<TSelf>, IVectorScalarOperators<TSelf, TScalar>;
