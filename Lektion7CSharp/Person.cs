using System;
using System.Collections.Generic;
using System.Text;

namespace Lektion7CSharp
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
