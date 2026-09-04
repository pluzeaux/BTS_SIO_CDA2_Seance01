namespace CompteBancaire;

public abstract class CompteBancaire
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public decimal Solde { get; set; }

    public CompteBancaire(int id, string nom, decimal solde)
    {
        Id = id;
        Nom = nom;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        Solde += montant;
    }

    public virtual void Debiter(decimal montant)
    {
        if (montant <= Solde)
        {
            Solde -= montant;
        }
        else
        {
            throw new InvalidOperationException("Solde insuffisant pour effectuer le débit.");
        }
    }
}
