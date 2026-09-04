## BTS SIO SLAM 2 
## CDA

# Gestion de comptes bancaires

Ce projet est une application console C# permettant de manipuler différents types de comptes bancaires.

## Prérequis

* .NET 10 SDK
* Visual Studio Code avec l'extension **C# Dev Kit**, ou un autre environnement compatible C#/.NET

Vérifier l'installation de .NET :

```bash
dotnet --version
```

## Lancer le projet

Depuis le répertoire du projet :

```bash
dotnet run
```

## Organisation

Le projet contient plusieurs types de comptes bancaires :

* `CompteBancaire` : classe de base commune aux différents comptes ;
* `CompteCourant` : compte autorisant un découvert et appliquant des frais sur les débits ;
* `CompteEpargne` : compte pouvant produire des intérêts ;
* `CompteEtudiant` : compte avec découvert et tarification spécifique ;
* `ComptePremium` : compte bénéficiant de conditions particulières.

Le fichier `Program.cs` contient un exemple d'utilisation de ces différentes classes.

## Objectif

Le projet constitue une base de travail, volontairement imparfaite, qui sera progressivement modifiée et enrichie au cours des exercices.
