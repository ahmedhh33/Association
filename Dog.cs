using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    internal class Dog
    {
        public string breed { get; set; }
        public string name { get; set; }
        public Dog(string breed , string name)
        {
            this.breed = breed;
            this.name = name;
        }
    }
}
