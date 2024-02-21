using Les_collections;
using System.Collections;
using static Les_collections.Film;
#region Demo

ArrayList arraylist = new ArrayList();

arraylist.Add(0);
arraylist.Add(new DateTime());
arraylist.Add("David");

List<int> listTest = new List<int>();
listTest.Add(1);
listTest.Add(2);
listTest.Add(3);
listTest.Add(4);
listTest.Add(5);
listTest.Add(1);
listTest.Add(2);
listTest.Add(3);
listTest.Add(4);
listTest.Add(5);

foreach (int item in listTest)
{
    Console.WriteLine(item);
}
listTest.Remove(5);
Console.WriteLine("Le remove retire le premiere élément trouvé");

listTest.RemoveAll( x => x == 3);
Console.WriteLine("Le removeAll enleve toutes les valeurs de la fonction anonyme");

Dictionary<string, DateTime> dictionary = new Dictionary<string, DateTime>();
dictionary.Add("dada",DateTime.Now);
dictionary.Add("Arthur", new DateTime(1212,12,12));
dictionary.Add("Merlin", new DateTime(1111, 11, 11));

Console.WriteLine(dictionary["Arthur"]);
foreach (KeyValuePair<string,DateTime> item in dictionary)
{
    Console.WriteLine(item);
    
}
#endregion

#region Exo1

/*
 * Donne le casting de chaque film de star wars en utilisant un dictionnaire
 *
 */


Dictionary<string, string[]> dictionaryStarWars = new Dictionary<string, string[]>();

dictionaryStarWars.Add("La menace fantome", [ "Liam Neeson","Ewan McGregor", "Jake Lloyd"]);
dictionaryStarWars.Add("La guerre des clones", ["Hayden Christensen","Ewan McGregor","Natalie Portman"]);
dictionaryStarWars.Add("La Revanche des sith", ["Hayden Christensen", "Ewan McGregor", "Natalie Portman"]);

dictionaryStarWars.Add("Un nouvel espoir", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]);
dictionaryStarWars.Add("L'empire contre attaque", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]);
dictionaryStarWars.Add("Le retour du jedi", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]);

dictionaryStarWars.Add("Le reveil de la force", ["Daisy Ridley", "John boyega", "Adam Driver"]);
dictionaryStarWars.Add("Les derniers Jedi", ["Daisy Ridley", "John boyega", "Adam Driver"]);
dictionaryStarWars.Add("L'ascension des Skywalkers", ["Daisy Ridley", "John boyega", "Adam Driver"]);

foreach (KeyValuePair<string, string[]> item in dictionaryStarWars)
{
    Console.WriteLine("*********************************************");
    Console.WriteLine($"*** Titre du film : {item.Key} ***");
    Console.WriteLine("*********************************************");
    Console.WriteLine("----->Liste des acteurs");
    foreach (string actor in item.Value)
    {
        Console.WriteLine($"------------------>{actor}");
    }
}

List<Film> filmStarWars = new List<Film>();
filmStarWars.Add(new Film("La menace fantome", ["Liam Neeson", "Ewan McGregor", "Jake Lloyd"]));
filmStarWars.Add(new Film("La guerre des clones", ["Hayden Christensen", "Ewan McGregor", "Natalie Portman"]));
filmStarWars.Add(new Film("La Revanche des sith", ["Hayden Christensen", "Ewan McGregor", "Natalie Portman"]));

filmStarWars.Add(new Film("Un nouvel espoir", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]));
filmStarWars.Add(new Film("L'empire contre attaque", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]));
filmStarWars.Add(new Film("Le retour du jedi", ["Mark Hamill", "Harrison Ford", "Carrie Fisher"]));

filmStarWars.Add(new Film("Le reveil de la force", ["Daisy Ridley", "John boyega", "Adam Driver"]));
filmStarWars.Add(new Film("Les derniers Jedi", ["Daisy Ridley", "John boyega", "Adam Driver"]));
filmStarWars.Add(new Film("L'ascension des Skywalkers", ["Daisy Ridley", "John boyega", "Adam Driver"]));


foreach (Film item in filmStarWars)
{
    Console.WriteLine($"Le titre du film : {item.titre}");
    Console.WriteLine("------> La liste des Acteurs : ");
    foreach (var actor in item.actor)
    {
        Console.WriteLine($"{actor}");
    }
}


#endregion


