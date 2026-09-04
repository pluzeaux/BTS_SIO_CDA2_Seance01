using Strategie.Model;

var courant = new CompteCourant(1, "Dupont", 1000m, 200m);
var etudiant = new CompteEtudiant(2, "Martin", 500m, 100m);
var premium = new ComptePremium(3, "Durand", 2000m, 0.02m, 500m);

courant.Debiter(100m);
etudiant.Debiter(100m);
premium.Debiter(100m);

Console.WriteLine(courant.Solde);
Console.WriteLine(etudiant.Solde);
Console.WriteLine(premium.Solde);
