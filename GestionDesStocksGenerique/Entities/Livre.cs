using GestionDesStocksGenerique.Interfaces;

namespace GestionDesStocksGenerique.Entities;

public class Livre : IProduit
{
    public string Nom { get; set; }
    public double Prix { get; set; }

    public Livre(string nom, double prix)
    {
        Nom = nom;
        Prix = prix;
    }

    public override string ToString() => $"Livre {Nom}, au prix de {Prix} euro";

}