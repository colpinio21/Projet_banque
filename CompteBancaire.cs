using System;

public abstract class CompteBancaire {
    public string NumeroDeCompte { get; protected set; }
    public decimal Solde { get; protected set; }

    public CompteBancaire(string numeroDeCompte, decimal soldeInitial = 0) {
        NumeroDeCompte = numeroDeCompte;
        Solde = soldeInitial;
    }

    public abstract void CalculerFrais();
    public abstract string ObtenirPolitiqueBancaire();

    public virtual void AfficherSolde() {
        Console.WriteLine($"Solde du compte {NumeroDeCompte}: {Solde} €");
    }

    public abstract void Depot(decimal montant);
    public abstract void Retrait(decimal montant);
}