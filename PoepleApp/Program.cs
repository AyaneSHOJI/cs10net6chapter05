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


WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}",
            arg0: alice.Name,
            arg1: alice.DateOfBirth);

WriteLine($"{ bob.Name } is a {Person.Species}");

WriteLine($"{bob.Name} was bon on {bob.HomePlanet}");

WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}",
            arg0: blankPerson.Name,
            arg1: blankPerson.HomePlanet,
            arg2: blankPerson.Instantiated);

// p.191 Making a field static
BankAccount.InterestRate = 0.012M; // stored a shared value

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400;

WriteLine($"{jonesAccount.AccountName} earned {(jonesAccount.Balance * BankAccount.InterestRate).ToString("c")}"); // add currency format with toString("c") or we can use formatting as below
WriteLine(format: "{0} earned {1:C} interent.",
            arg0: jonesAccount.AccountName,
            arg1: jonesAccount.Balance * BankAccount.InterestRate);