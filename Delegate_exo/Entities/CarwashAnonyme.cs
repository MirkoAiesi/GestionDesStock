namespace Delegate_exo.Voiture;

public class CarwashAnonyme
{
    public delegate void GestionAuto(Voiture v);

    public void Traiter(Voiture v)
    {
        GestionAuto workflow = (voiture) => Console.WriteLine($"je prépare la voiture : {voiture.Plaque}");
        workflow += (voiture) => Console.WriteLine($"je prépare la voiture : {voiture.Plaque}");
        workflow += (voiture) => Console.WriteLine($"je prépare la voiture : {voiture.Plaque}");
        workflow += (voiture) => Console.WriteLine($"je prépare la voiture : {voiture.Plaque}");

        workflow(v);

    }
    
}