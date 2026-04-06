namespace System.Numerics;

// shitty?

public interface IVector<V, S> :
    IUnaryPlusOperators<V, V>,
    IUnaryNegationOperators<V, V>,

    IAdditiveIdentity<V, V>,
    IMultiplicativeIdentity<V, V>,


    IMultiplyOperators<V, V, S>,
    IAdditionOperators<V, V, V>,
    ISubtractionOperators<V, V, V>,

    IEqualityOperators<V, V, bool>
        where S : INumber<S>
        where V : IVector<V, S>, IVectorScalarOperators<V, S>
{
    static abstract V One { get; }

    static abstract V Zero { get; }
}

// generic constraints need to have "not" to combine
public interface IVectorScalarOperators<V, S> :
    IMultiplyOperators<V, S, V>,
    IDivisionOperators<V, S, V>,
    IAdditionOperators<V, S, V>,
    ISubtractionOperators<V, S, V>
        where S : INumber<S>
        where V : IVector<V, S>, IVectorScalarOperators<V, S>;
