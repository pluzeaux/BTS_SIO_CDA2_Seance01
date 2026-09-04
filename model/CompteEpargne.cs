namespace Strategie.Model;

public class CompteEpargne : CompteBancaire
{
    public decimal TauxInteret { get; set; }

    public CompteEpargne(int id, string nom, decimal solde = 0, decimal tauxInteret = 0m) : base(id, nom, solde)
    {
        TauxInteret = tauxInteret;
    }

    public void CalculerInterets()
    {
        Solde += Solde * TauxInteret;
    }
}
