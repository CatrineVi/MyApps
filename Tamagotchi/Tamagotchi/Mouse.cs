using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class Mouse : AbstractAnimal
    {
        public override void Speak()
        {
            base.Speak();
            Console.WriteLine("Peak peak");
        }

        public Mouse(string name) : base(name) { }

    }
}
