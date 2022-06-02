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
    }
}
