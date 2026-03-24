namespace Delegate_exo.Voiture;

public class Carwash
{
    public delegate void GestionVoiture (Voiture v);
    private void Preparer(Voiture v)
    {
        Console.WriteLine($"je prépare la voiture : {v.Plaque}");
    }
    private void Laver(Voiture v)
    {
        Console.WriteLine($"je lave la voiture : {v.Plaque}");
    }
    private void Secher(Voiture v)
    {
        Console.WriteLine($"je sèche la voiture : {v.Plaque}");
    }
    private void Finaliser(Voiture v)
    {
        Console.WriteLine($"je finalise la voiture : {v.Plaque}");
    }

    public void Traiter(Voiture v)
    {
        GestionVoiture gestionVoiture = Preparer;
        gestionVoiture += Laver;
        gestionVoiture += Secher;
        gestionVoiture += Finaliser;

        gestionVoiture(v);
    }
}