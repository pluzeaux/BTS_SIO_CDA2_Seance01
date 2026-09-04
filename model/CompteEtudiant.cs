namespace CompteBancaire;

public sealed class CompteEtudiant : CompteBancaire
{
    public decimal DecouvertAutorise { get; set; }
    public CompteEtudiant(int id, string nom, decimal solde, decimal decouvertAutorise = 0) : base(id, nom, solde)
    {
        DecouvertAutorise = decouvertAutorise;
    }

    public override void Debiter(decimal montant)
    {
        if (montant <= Solde + DecouvertAutorise)
        {
            Solde -= montant + Math.Max(1m, montant * 0.01m);
        }
        else
        {
            throw new InvalidOperationException("Solde insuffisant pour effectuer le débit.");
        }
    }
}