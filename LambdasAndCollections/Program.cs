// See https://aka.ms/new-console-template for more information

using System;

// since .NET 5.0 we don't need the main method

var heroes = new List<Hero> {
    new("Wade", "Wilson", "Deadpol", false),
    new(string.Empty, string.Empty, "Homelander", true),
    new("Bruce", "Wayne", "Batman", false),
    new(string.Empty, string.Empty, "Stormfront", true)
};

var result = FilterHeroesWhoCanFly(heroes);
var heroesWhoCanFly = string.Join(", ", result);
Console.WriteLine(heroesWhoCanFly);

// 1
List<Hero> FilterHeroesWhoCanFly(List<Hero> heroes){
    var resultlist = new List<Hero>();
    foreach(var hero in heroes){
        if(hero.canFly){
            resultlist.Add(hero);
        }
    }

    return resultlist;
}

// type of a class
// saves a lot of time and initialize all these
// attributes
record Hero(string FirstName, string LastName, string HeroName, bool canFly);