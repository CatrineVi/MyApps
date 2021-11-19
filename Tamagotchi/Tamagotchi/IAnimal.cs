using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal interface IAnimal
    {
        string Name { get; }

        int Age { get; }

        void Die();

        void Eat();

        void Drink();

        void Speak();

    }
}
