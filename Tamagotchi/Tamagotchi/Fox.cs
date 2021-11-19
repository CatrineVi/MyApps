using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Fox : AbstractAnimal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Frr frr");
        }

        public Fox(string name) : base(name) { }

    }
}
