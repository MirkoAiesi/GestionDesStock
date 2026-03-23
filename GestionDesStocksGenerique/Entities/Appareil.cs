using GestionDesStocksGenerique.Interfaces;

namespace GestionDesStocksGenerique.Entities;

public class Appareil : IProduit
{
    public string Nom { get; set; }
    public double Prix { get; set; }

    public Appareil(string nom, double prix)
    {
        Nom = nom;
        Prix = prix;
    }
    public override string ToString() => $"Appareil {Nom}, au prix de {Prix} euro";
}