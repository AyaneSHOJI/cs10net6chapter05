using Packt.Shared;
using static System.Console;
using System;

// p.180 Building class libraries
Person bob = new();
WriteLine(bob.ToString()); //toString method in the System.Object shows the full namespace and type name

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1965, 12, 22);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = WondersOfTheAncientWorld.HangingGardenOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
bob.Children.Add(new Person { Name = "Zoe" });
bob.Children.Add(new(){ Name = "Alfred" });

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
            arg0: bob.Name,
            arg1: bob.DateOfBirth);

WriteLine($"{bob.Name}'s favorite wonder is {bob.FavoriteAncientWonder}. Its interger is {(int)bob.FavoriteAncientWonder}.");

WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");

WriteLine($"{bob.Name}'s has {bob.Children.Count} children: ");

for(int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"    {bob.Children[childIndex].Name}");
}

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new DateTime(1998, 3, 7)
};

// p.194 initializing fields with constructors
Person blankPerson = new();

Person gunny = new(initialName: "Gunny", homePlanet: "Mars");

// Outputs
WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
            arg0: alice.Name,
            arg1: alice.DateOfBirth);

WriteLine($"{ bob.Name } is a {Person.Species}");

WriteLine($"{bob.Name} was bon on {bob.HomePlanet}");

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
            arg0: blankPerson.Name,
            arg1: blankPerson.HomePlanet,
            arg2: blankPerson.Instantiated);

WriteLine(format: "{0} of {1} was created at {2:hh:mm:hh:ss} on a {2:dddd}",
            arg0: gunny.Name,
            arg1: gunny.HomePlanet,
            arg2: gunny.Instantiated);

// p.191 Making a field static
BankAccount.InterestRate = 0.012M; // stored a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine($"{jonesAccount.AccountName} earned {(jonesAccount.Balance * BankAccount.InterestRate).ToString("c")}"); // add currency format with toString("c") or we can use formatting as below
WriteLine(format: "{0} earned {1:C} interent.",
            arg0: jonesAccount.AccountName,
            arg1: jonesAccount.Balance * BankAccount.InterestRate);

// p.195 Writing and calling methods
bob.WriteToConsole();
WriteLine(bob.GetOrigin()); 

// P.197 Language support for tuples
(string, int) fruit = bob.GetFruit();

WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

var fruitNamed = bob.GetNamedFruit();

WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}");

// P.200 Parameters
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));

// p.201 Passing opitonal and named parameters
WriteLine(bob.OptionalParameters());    
WriteLine(bob.OptionalParameters("Jamp", 98.5));

// we can change the order of parameters
WriteLine(bob.OptionalParameters(number: 52.7, command: "Hide!"));

// we can skip parameters
WriteLine(bob.OptionalParameters("Poke!", active:false));

int a = 10;
int b = 20;
int c = 30;
WriteLine($"Before: a = {a}, b = {b}, c = {c}");
bob.PassingParameters(a, ref b, out c);
WriteLine($"After : a = {a}, b = {b}, c = {c}");

int d = 10;
int e = 20;
WriteLine($"Before d = {d}, e = {e}, f doesn't exsite yet:");
bob.PassingParameters(d, ref e, out int f);
WriteLine($"After : d = {d}, e = {e}, f = {f}");

// p.206 Read-only properties
Person sam = new()
{
    Name = "Sam",
    DateOfBirth = new(1972, 1, 27)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favorite ice-cream is {sam.FavoriteIceCream}.");

sam.FavoritePrimaryColor = "red";
WriteLine($"Sam's favorite primary color is {sam.FavoritePrimaryColor}.");

// p.210 indexers
sam.Children.Add(new() { Name = "Charlie" });
sam.Children.Add(new() { Name = "Ella" });

WriteLine($"Sam's first child is {sam.Children[0].Name}");
WriteLine($"Sam's first child is {sam[0].Name}");
WriteLine($"Sam's second child is {sam.Children[1].Name}");
WriteLine($"Sam's second child is {sam[1].Name}");
