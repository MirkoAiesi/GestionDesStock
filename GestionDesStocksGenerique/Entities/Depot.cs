using GestionDesStocksGenerique.Interfaces;

namespace GestionDesStocksGenerique.Entities;

public class Depot<T> : IDepot<T>
{
    private List<T> _stock = new List<T>();
    public void Ajouter(T element)
    {
        _stock.Add(element);
    }

    public void Retirer(int index)
    {
        _stock.RemoveAt(index);
    }

    public T Recuperer(int index)
    {
        return _stock[index];
    }

    public int NombreElements { get => _stock.Count;}

    public void Afficher()
    {
        Console.WriteLine($"Contenu du dépôt :");
        foreach (var item in _stock)
        {
            Console.WriteLine(item.ToString());
        }
    }
}