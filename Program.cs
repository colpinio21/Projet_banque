using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Bienvenue dans notre banque!");

        Console.Write("Veuillez entrer le numéro de compte épargne : ");
        string? numeroEpargne = Console.ReadLine();

        Console.Write("Veuillez entrer le solde initial du compte épargne : ");
        decimal soldeEpargne = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Veuillez entrer le taux d'intérêt du compte épargne (par exemple, 0.03 pour 3%) : ");
        decimal tauxInteret = Convert.ToDecimal(Console.ReadLine());

        CompteEpargne compteEpargne = new CompteEpargne(numeroEpargne, soldeEpargne, tauxInteret);

        Console.Write("\nVeuillez entrer le numéro de compte courant : ");
        string? numeroCourant = Console.ReadLine();

        Console.Write("Veuillez entrer le solde initial du compte courant : ");
        decimal soldeCourant = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Veuillez entrer le découvert autorisé du compte courant : ");
        decimal decouvertAutorise = Convert.ToDecimal(Console.ReadLine());

        CompteCourant compteCourant = new CompteCourant(numeroCourant, soldeCourant, decouvertAutorise);

        Console.WriteLine("\nComptes créés avec succès!");

        GestionComptes(compteEpargne, compteCourant);
    }

    static void GestionComptes(CompteEpargne compteEpargne, CompteCourant compteCourant) {
        while (true) {
            Console.WriteLine("\nQue souhaitez-vous faire ?");
            Console.WriteLine("1. Dépôt sur le compte épargne");
            Console.WriteLine("2. Retrait sur le compte épargne");
            Console.WriteLine("3. Dépôt sur le compte courant");
            Console.WriteLine("4. Retrait sur le compte courant");
            Console.WriteLine("5. Afficher le solde des comptes");
            Console.WriteLine("6. Quitter");

            Console.Write("Entrez le numéro de votre choix : ");
            int choix = Convert.ToInt32(Console.ReadLine());

            switch (choix) {
                case 1:
                    Console.Write("Entrez le montant à déposer sur le compte épargne : ");
                    decimal montantDepotEpargne = Convert.ToDecimal(Console.ReadLine());
                    compteEpargne.Depot(montantDepotEpargne);
                    break;
                case 2:
                    Console.Write("Entrez le montant à retirer du compte épargne : ");
                    decimal montantRetraitEpargne = Convert.ToDecimal(Console.ReadLine());
                    compteEpargne.Retrait(montantRetraitEpargne);
                    break;
                case 3:
                    Console.Write("Entrez le montant à déposer sur le compte courant : ");
                    decimal montantDepotCourant = Convert.ToDecimal(Console.ReadLine());
                    compteCourant.Depot(montantDepotCourant);
                    break;
                case 4:
                    Console.Write("Entrez le montant à retirer du compte courant : ");
                    decimal montantRetraitCourant = Convert.ToDecimal(Console.ReadLine());
                    compteCourant.Retrait(montantRetraitCourant);
                    break;
                case 5:
                    Console.WriteLine("Solde du compte épargne : ");
                    compteEpargne.AfficherSolde();
                    Console.WriteLine("Solde du compte courant : ");
                    compteCourant.AfficherSolde();
                    break;
                case 6:
                    Console.WriteLine("Merci d'avoir utilisé nos services. Au revoir!");
                    return;
                default:
                    Console.WriteLine("Choix invalide. Veuillez choisir une option valide.");
                    break;
            }
        }
    }
}