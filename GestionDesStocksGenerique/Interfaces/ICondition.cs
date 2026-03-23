namespace GestionDesStocksGenerique.Interfaces;

public interface ICondition<T>
{
    bool Verifier(T element);
}