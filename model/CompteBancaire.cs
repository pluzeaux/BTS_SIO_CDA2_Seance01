namespace Strategie.Model;

public abstract class CompteBancaire
{
    public int Id { get; }
    public string Nom { get; set; }
    public decimal Solde { get; protected set; }

    public CompteBancaire(int id, string nom, decimal solde)
    {
        Id = id;
        Nom = nom;
        Solde = solde;
    }

    public void Crediter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant doit être strictement positif.");
        }

        Solde += montant;
    }

    public virtual void Debiter(decimal montant)
    {
        if (montant <= 0)
        {
            throw new ArgumentException("Le montant doit être strictement positif.");
        }

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
