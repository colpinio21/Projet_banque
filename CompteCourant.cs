public class CompteCourant : CompteBancaire {
    public decimal DecouvertAutorise { get; private set; }

    public CompteCourant(string numeroDeCompte, decimal soldeInitial = 0, decimal decouvertAutorise = 500)
        : base(numeroDeCompte, soldeInitial) {
        DecouvertAutorise = decouvertAutorise;
    }

    public override void CalculerFrais() {
        // Calcul des frais pour le compte courant
    }

    public override string ObtenirPolitiqueBancaire() {
        return "Politique bancaire pour le compte courant...";
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
        if (montant > (Solde + DecouvertAutorise)) {
            Console.WriteLine("Retrait dépassant le découvert autorisé.");
            return;
        }
        Solde -= montant;
        AfficherSolde();
    }
}