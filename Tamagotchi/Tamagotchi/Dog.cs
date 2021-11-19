using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Dog : AbstractAnimal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Woof");
        }

        public Dog(string name) : base(name) { }

    }
}
