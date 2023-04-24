using LinQ;

// var liste = new MaListe(10);
// foreach (var item in liste)
// {
//     System.Console.WriteLine(item);
// }

// int[] tab = new[] { 1, 2, 3, 4, 5};
// System.Console.WriteLine(tab.CompterPair());

List<Personne> personnes = new()
{
    new() { Nom = "Dupont", Prenom = "Jean", TailleCm = 175, Sexe = Sexe.Homme },
    new() { Nom = "Dupont", Prenom = "Jeanne", TailleCm = 156, Sexe = Sexe.Femme, DateNaissance = new(1956, 2, 7)},
    new() { Nom = "Durand", Prenom = "Marc", TailleCm = 192, Sexe = Sexe.Homme, DateNaissance = new(1959, 10, 5) },
    new() { Nom = "Thomas", Prenom = "Gérard", TailleCm = 182, Sexe = Sexe.Homme },
    new() { Nom = "Cerkezoglu", Prenom = "Nurbey", TailleCm = 175, Sexe = Sexe.Homme, DateNaissance = new(1997, 11, 03)},
    new() { Nom = "Trancart", Prenom = "Jérôme", TailleCm = 175, Sexe = Sexe.Homme, DateNaissance = new(1989, 7, 29)},
};


///CREE UNE NOUVELLE COLLECTION IENUMERABLE EN MEMOIRE SUR LA BASE DE LA PRECEDENTE
// List<string> nomsDeFamille = personnes.Select(p => p.Nom).ToList();

// foreach (var item in nomsDeFamille)
// {
//     System.Console.WriteLine(item);
// }

var avecDate = personnes.Where(p => p.DateNaissance.HasValue);

foreach (var item in avecDate)
{
    System.Console.WriteLine($" {item.Nom} {item.Prenom} né(e) le {item.DateNaissance!.Value:dd/MM/yyyy}");
}


