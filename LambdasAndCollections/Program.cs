// See https://aka.ms/new-console-template for more information

using System;

// since .NET 5.0 we don't need the main method

var heroes = new List<Hero> {
    new("Wade", "Wilson", "Deadpol", false),
    new(string.Empty, string.Empty, "Homelander", true),
    new("Bruce", "Wayne", "Batman", false),
    new(string.Empty, string.Empty, "Stormfront", true)
};

// 1
var result = FilterHeroesWhoCanFly(heroes);
var heroesWhoCanFly = string.Join(", ", result);
Console.WriteLine(heroesWhoCanFly);

// 2
var result1 = FilterHeroesWhoseLastNameIsUnknown(heroes);
var heroesWhoseLastNameIsUnknown = string.Join(", ", result1);
Console.WriteLine(heroesWhoseLastNameIsUnknown);

// 3
var result2 = FilterHeroes(heroes, h => h.canFly);
var fh1 = string.Join(", ", result2);
Console.WriteLine(fh1);

// 4

Filter_IE(new [] {"Homelander", "Stormfront", "The Deep"}, hn => hn.StartsWith("H"));

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

// 2
List<Hero> FilterHeroesWhoseLastNameIsUnknown(List<Hero> heroes){
    var resultlist = new List<Hero>();
    foreach(var hero in heroes){
        if(string.IsNullOrEmpty(hero.LastName)){
            resultlist.Add(hero);
        }
    }

    return resultlist;
}

// 3
// this makes the function 1 obsolete
List<Hero> FilterHeroes(List<Hero> heroes, Filter f){
    var resultlist = new List<Hero>();
    foreach(var hero in heroes){
        if(f(hero)){
            resultlist.Add(hero);
        }
    }

    return resultlist;
}

// 4
IEnumerable<T> Filter_IE<T>(IEnumerable<T> items, Filter_1<T> f){
    foreach(var item in items){
        if(f(item)){
            yield return item;
        }
    }
}

// Func<T, bool> f --> same as delegate Filter_1
// can be used in place of Filter_1
// 3
delegate bool Filter(Hero h);
// 4
delegate bool Filter_1<T>(T h);


// type of a class
// saves a lot of time and initialize all these
// attributes
record Hero(string FirstName, string LastName, string HeroName, bool canFly);