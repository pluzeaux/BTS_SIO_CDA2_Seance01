namespace CompteBancaire;

public sealed class CompteCourant : CompteBancaire
{
    public decimal DecouvertAutorise { get; set; }
    public CompteCourant(int id, string nom, decimal solde, decimal decouvertAutorise = 0) : base(id, nom, solde)
    {
        DecouvertAutorise = decouvertAutorise;
    }

    public override void Debiter(decimal montant)
    {
        if (montant <= Solde + DecouvertAutorise)
        {
            Solde -= montant + Math.Max(1m, montant * 0.02m);
        }
        else
        {
            throw new InvalidOperationException("Solde insuffisant pour effectuer le débit.");
        }
    }
}
