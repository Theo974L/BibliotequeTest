using bibli;

bool exit = false;

bibliotequeGestion bbg = new bibliotequeGestion(new List<Livre>(),new List<User>());

User user1 = new User(1,"a","a",new List<Livre>(),false);
User user2 = new User(2, "b", "b", new List<Livre>(), true);

Livre livre1 = new Livre("L'ombre du vent", "Carlos Ruiz Zafón", "1", new DateTime(2001, 1, 1),false);
Livre livre2 = new Livre("Les Misérables", "Victor Hugo", "2", new DateTime(1862, 1, 1), false);
Livre livre3 = new Livre("Harry Potter à l'école des sorciers", "J.K. Rowling", "3", new DateTime(1997, 1, 1), false);
Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "4", new DateTime(1943, 1, 1), false);
Livre livre5 = new Livre("La Ferme des animaux", "George Orwell", "5", new DateTime(1945, 1, 1), false);
bbg.ajouterUser(user1);
bbg.ajouterUser(user2);

bbg.AjouterLivreBibli(livre1);
bbg.AjouterLivreBibli(livre2);
bbg.AjouterLivreBibli(livre3);
bbg.AjouterLivreBibli(livre4);
bbg.AjouterLivreBibli(livre5);

/*
user1.AjouterLivre(livre5, bbg);
user1.ConsulterLivre();
user1.AjouterLivre(livre5, bbg);
user1.SupprimerLivre(livre4, bbg);
user1.ConsulterLivre();
*/

while (!exit)
{
    try
    {
        Console.WriteLine("\n/***********************************************************/\n");
        Console.WriteLine("Choisi une option : ");
        Console.WriteLine("1 : Voir les livres");
        Console.WriteLine("2 : Voir les utilisateur");
        Console.WriteLine("3 : Voir les livres de l'utilisateur");
        Console.WriteLine("4 : Ajouter un livre");
        Console.WriteLine("5 : Supprimer un livre");
        Console.WriteLine("6 : Quit");
        Console.WriteLine("\n/***********************************************************/\n");
        int choix = int.Parse(Console.ReadLine());
        Console.Clear();
        switch (choix)
        {
            case 1:
                bbg.ConsulterLivre();
                break;
            case 2:
                bbg.ConsulterUser();
                break;
            case 3:
                user1.ConsulterLivre();
                break;
            case 4:
                bbg.ConsulterLivre();
                Console.WriteLine("Choisi un livre");
                string nblivre =  Console.ReadLine();
                user1.AjouterLivre(nblivre,bbg);
                user1.ConsulterLivre();
                break;
            case 5:
                user1.ConsulterLivre();
                Console.WriteLine("Choisi un livre a supprimer");
                string numlivre2 = Console.ReadLine();
                user1.SupprimerLivre(numlivre2, bbg);
                user1.ConsulterLivre();
                break;
            case 6:
                exit = true;
                break;
        }
    }
    catch (Exception ex)
    {

    }
    
}



