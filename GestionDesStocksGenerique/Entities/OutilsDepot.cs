using GestionDesStocksGenerique.Interfaces;

namespace GestionDesStocksGenerique.Entities;

public static class OutilsDepot
{
    public static void Echanger<T>(ref T a, ref T b)
    {
        (a, b) = (b, a);
    }

    public static int Trouver<T>(List<T> list, T valeur)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Equals(valeur))
            {
                return i;
            }
        } 
        return -1;
    }

    public static List<T> Filtrer<T>(List<T> list, ICondition<T> condition)
    {
        List<T> resultat = new List<T>();
        foreach (T element in list)
        {
            if (condition.Verifier(element))
            {
                resultat.Add(element);
            }
        }
        return resultat;
    }
}