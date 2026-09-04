namespace Strategie.Model;

public sealed class CompteEtudiant : CompteBancaire
{
    public decimal DecouvertAutorise { get; set; }
    public CompteEtudiant(int id, string nom, decimal solde, decimal decouvertAutorise = 0) : base(id, nom, solde)
    {
        DecouvertAutorise = decouvertAutorise;
    }

    public override void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant doit être strictement positif.");
        }

        decimal frais = Math.Max(1m, montant * 0.01m);

        if (montant + frais <= Solde + DecouvertAutorise)
        {
            Solde -= montant + frais;
        }
        else
        {
            throw new InvalidOperationException("Solde insuffisant pour effectuer le débit.");
        }
    }
}