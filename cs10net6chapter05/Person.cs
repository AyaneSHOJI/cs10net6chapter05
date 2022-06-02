using Packt.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Packt.Shared 
{
    public class Person : Object //F12 to see definition
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public WondersOfTheAncientWorld BucketList;
        public List<Person> Children = new List<Person>();// List should be initialized to avoid runtime exceptions
        public const string Species = "Homo Sapien";
        public readonly string HomePlanet = "Earth"; // better choice thant const
        public readonly DateTime Instantiated;

        // constructors
        public Person()
        {
            // set default values for fields including read-only fields
            Name = "Unknown";
            Instantiated = DateTime.Now;  
            
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}";
        }

        // how to get multiple returned values ?
        public class TextAndNumber
        {
            public string Text;
            public int Number;
        }

        public class LifeTheUniverseAndEverything
        {
            public TextAndNumber GetTheData()
            {
                return new TextAndNumber
                {
                    Text = "What's the meaning of life ?"
                    Number = 42
                };
            }
        }
    }
}
