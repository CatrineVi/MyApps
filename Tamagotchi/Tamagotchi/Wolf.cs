using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Wolf : AbstractAnimal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Woof Awww");
        }

        public Wolf(string name) : base(name) { }

    }
}
