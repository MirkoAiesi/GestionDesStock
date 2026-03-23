using GestionDesStocksGenerique.Interfaces;

namespace GestionDesStocksGenerique.Entities;

public class ConditionLivreCher : ICondition<Livre>
{
    public bool Verifier(Livre livre)
    {
        return livre.Prix > 10.0;
    }
}