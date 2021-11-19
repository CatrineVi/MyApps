using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Cat : AbstractAnimal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Meow");
        }

        public Cat(string name) : base(name) { }

    }
}
