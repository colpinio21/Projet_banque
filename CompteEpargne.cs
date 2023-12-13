public class CompteEpargne : CompteBancaire {
    public decimal TauxInteret { get; private set; }

    public CompteEpargne(string numeroDeCompte, decimal soldeInitial = 0, decimal tauxInteret = 0.03m)
        : base(numeroDeCompte, soldeInitial) {
        TauxInteret = tauxInteret;
    }

    public override void CalculerFrais() {
        // Calcul des frais pour le compte épargne
    }

    public override string ObtenirPolitiqueBancaire() {
        return "Politique bancaire pour le compte épargne...";
    }

    public override void Depot(decimal montant) {
        if (montant <= 0.01m) {
            Console.WriteLine("Le montant du dépôt doit être supérieur à 0.01€.");
            return;
        }
        Solde += montant;
        AfficherSolde();
    }

    public override void Retrait(decimal montant) {
        if (montant > Solde) {
            Console.WriteLine("Fonds insuffisants pour le retrait.");
            return;
        }
        Solde -= montant;
        AfficherSolde();
    }
}