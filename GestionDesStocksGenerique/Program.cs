using GestionDesStocksGenerique.Entities;

DepotProduit<Livre> depotLivres = new DepotProduit<Livre>();
depotLivres.Ajouter(new Livre("One piece", 6.95));
depotLivres.Ajouter(new Livre("Game Of Thrones", 19.99));

DepotProduit<Appareil> depotAppareils = new DepotProduit<Appareil>();
depotAppareils.Ajouter(new Appareil("iPhone 17", 899));
depotAppareils.Ajouter(new Appareil("Raclette party", 49.99));
Console.WriteLine();
//TEST AFFICHAGE -----------------------------------
depotLivres.Afficher();
depotAppareils.Afficher();
//TEST ECHANGE -------------------------------------
Console.WriteLine();
Livre livre1 = depotLivres.Recuperer(0);
Livre livre2= depotLivres.Recuperer(1);
OutilsDepot.Echanger(ref livre1, ref livre2);
Console.WriteLine($"Après l'echange : {livre1.Nom} {livre1.Prix} / {livre2.Nom} {livre2.Prix}");
//TEST TROUVER -------------------------------------
Appareil chercheAppareil = depotAppareils.Recuperer(0);
List<Appareil> listeAppareils = new List<Appareil>();
for (int i = 0; i < depotAppareils.NombreElements; i++)
{
    listeAppareils.Add(depotAppareils.Recuperer(i));
}

int indexTrouve = OutilsDepot.Trouver(listeAppareils, chercheAppareil);
Console.WriteLine($"L'appareil {chercheAppareil.Nom}  est à l'index {indexTrouve}");
//TEST FILTRER -------------------------------------
List<Livre> listeBruteLivre = new List<Livre>
{
    new Livre("seigneur des anneaux", 25),
    new Livre("berserk", 7),
    new Livre("LMP", 15)
};
ConditionLivreCher conditionPrix = new ConditionLivreCher();
List<Livre> livreFiltres = OutilsDepot.Filtrer(listeBruteLivre, conditionPrix);
foreach (var livre in livreFiltres)
{
    Console.WriteLine($"les livres plus chere que 10euro {livre.Nom} à {livre.Prix} euro");
}