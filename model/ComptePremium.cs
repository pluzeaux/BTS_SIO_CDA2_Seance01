namespace CompteBancaire
{
    public class ComptePremium : CompteBancaire
    {
        public decimal TauxInteret { get; set; }
        public decimal DecouvertAutorise { get; set; }

        public ComptePremium(int id, string nom, decimal solde = 0, decimal tauxInteret = 1, decimal decouvertAutorise = 0) : base(id, nom, solde)
        {
            TauxInteret = tauxInteret;
            DecouvertAutorise = decouvertAutorise;
        }

        public void CalculerInterets()
        {
            Solde += Solde * TauxInteret;
        }

        public new void Debiter(decimal montant)
        {
            if (montant <= Solde + DecouvertAutorise)
            {
                Solde -= montant;
            }
            else
            {
                throw new InvalidOperationException("Solde insuffisant pour effectuer le débit.");
            }
        }
    }
}
