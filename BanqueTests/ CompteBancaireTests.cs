using Banque;

namespace BanqueTests;

public class CompteBancaireTests
{
    [Fact]
    public void VérifierDébitCompteCorrect()
    {
        double soldeInitial=500000;
        double montantDébit=400000;
        double soldeAttendu=100000;

        var compte = new CompteBancaire("Pr. abdoulaye Diankha",soldeInitial);
        compte.Débiter(montantDébit);


        double soldeObtenu = compte.Balance;
        double tolerance = 0.001;

       Assert.True(Math.Abs(soldeAttendu - soldeObtenu) < tolerance, $"Le solde obtenu ({soldeObtenu}) est incorrect. Attendu: {soldeAttendu}.");

    }
       [Fact]
        public void DébiterMontantNégatifLèveArgumentOutOfRange()
        {
            
            var compte = new CompteBancaire("Amina Diagne", 1000);
            double montantADébiter = -500;

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => compte.Débiter(montantADébiter));
            Assert.Equal("montant", exception.ParamName); 
        }

         [Fact]
        public void DébiterMontantSupérieurSoldeLèveArgumentOutOfRange()
        {
            var compte = new CompteBancaire("Bacar Salim ", 1000);
            double montantADébiter = 1500;

            var exception = Assert.Throws<ArgumentOutOfRangeException>(() => compte.Débiter(montantADébiter));
            Assert.Equal("montant", exception.ParamName);  
        }
        
         [Fact]
         public void DébiterMontantValideRéduitSolde()
        {
            var compte = new CompteBancaire("Imane bacar", 1000);
            double montantADébiter = 500;
            double soldeAttendu = 1000 - montantADébiter;

            compte.Débiter(montantADébiter);

            
            Assert.Equal(soldeAttendu, compte.Balance, 0.001);  
        }

}