using Delegate_exo.Voiture;


Voiture v = new Voiture("1-BTO-658");
Carwash station = new Carwash();
CarwashAnonyme stationAnonyme = new CarwashAnonyme();

stationAnonyme.Traiter(v);