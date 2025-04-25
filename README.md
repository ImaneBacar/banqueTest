
# Banque

Ce projet est une application de gestion de comptes bancaires en C#.  
Il comprend une bibliothèque principale pour la gestion des comptes et un projet de tests unitaires pour valider les fonctionnalités.

## Structure du projet

### Bibliothèque principale : `Banque`

Le fichier [`CompteBancaire.cs`](Banque/CompteBancaire.cs) contient la classe principale `CompteBancaire`, qui permet de :

- Créer un compte bancaire avec un nom de client et un solde initial.
- Créditer un montant sur le compte.
- Débiter un montant du compte, avec des validations pour éviter les montants négatifs ou supérieurs au solde.
- Bloquer et débloquer le compte.

### Tests unitaires : `BanqueTests`

Le projet [`BanqueTests`](BanqueTests/) contient des tests unitaires pour valider les fonctionnalités de la classe `CompteBancaire`.  
Les tests sont écrits avec le framework [xUnit](https://xunit.net/).

Exemples de tests inclus :

- Vérification du débit correct d'un compte.
- Validation des exceptions levées pour des montants invalides (négatifs ou supérieurs au solde).

## Prérequis

- [.NET SDK](https://dotnet.microsoft.com/download) (version 8.0 ou supérieure)
- Un IDE comme [Visual Studio](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)

## Installation

1. Clonez ce dépôt :
   ```bash
   git clone https://github.com/ImaneBacar/banqueTest
   cd banqueTest-main
   ```

2. Restaurez les dépendances :
   ```bash
   dotnet restore
   ```

## Utilisation

Pour exécuter l'application :

```bash
cd Banque
dotnet run
```

Pour exécuter les tests :

```bash
cd BanqueTests
dotnet test
```
