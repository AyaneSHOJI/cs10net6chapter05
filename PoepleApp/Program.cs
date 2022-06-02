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