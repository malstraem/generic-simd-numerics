namespace System.Numerics;

// generic constraints need to have "not" to combine this two interfaces

public interface IVector<V, S> :
    IAdditiveIdentity<V, V>,
    IMultiplicativeIdentity<V, V>,

    IAdditionOperators<V, V, V>,
    ISubtractionOperators<V, V, V>,

    IMultiplyOperators<V, V, V>,
    IDivisionOperators<V, V, V>,

    IEqualityOperators<V, V, bool>
        where S : INumber<S>
        where V : IVector<V, S>, IVectorScalarOperators<V, S>
{
    static abstract V One { get; }

    static abstract V Zero { get; }
}

public interface IVectorScalarOperators<V, S> :
    IAdditionOperators<V, S, V>,
    ISubtractionOperators<V, S, V>,

    IMultiplyOperators<V, S, V>,
    IDivisionOperators<V, S, V>
        where S : INumber<S>
        where V : IVector<V, S>, IVectorScalarOperators<V, S>;
