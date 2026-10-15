# Parcours d'épreuves en C# (programmation orientée objet)

Application console en C# où une participante traverse un hall et des salles d'épreuves. Pour ouvrir chaque porte, elle doit utiliser un concept différent de la programmation orientée objet. Des spectateurs réagissent aux événements du parcours.

## Technologies

C#, .NET 8, application console

## Concepts mis en pratique

- **Héritage et polymorphisme** : une classe de base `Salle` et une classe de base `Porte`, avec des salles et des portes spécialisées (`SalleDelegue`, `SalleException`, `PorteDelegue`, `PorteException`)
- **Interface** : `IRepondreEpreuveSalles` définit comment répondre à chaque épreuve
- **Délégués** (`Action`, `Func`) : dans la salle des délégués, un objet `Hibou` exécute les fonctions de la salle pour reconstituer la phrase qui ouvre la porte
- **Événements** : les spectateurs s'abonnent aux applaudissements du hall
- **Gestion des exceptions** : dans la salle des exceptions, la participante trouve le bon code grâce aux exceptions levées par la porte (`FormatException`, `ArgumentOutOfRangeException`, etc.)

## Lancer le projet

Avec le SDK .NET 8 installé :

    dotnet run

Ou ouvrir `Salle_Final.sln` dans Visual Studio et appuyer sur F5.

---
Projet réalisé en décembre 2025 dans le cours Programmation orientée objet, Cégep de Shawinigan.
