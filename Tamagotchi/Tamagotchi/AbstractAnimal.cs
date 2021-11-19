using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class AbstractAnimal : IAnimal
    {
        public string Name { get; }

        public int Age { get; }

        public void Die()
        {
            Console.WriteLine("R.I.P.");
        }

        public void Drink()
        {
            Console.WriteLine("Да, я пью. Не осуждай.");
        }

        public void Eat()
        {
            Console.WriteLine("Nom nom...");
        }

        public virtual void Speak()
        {
            Console.Write($"{this.Name} говорит: ");
        }

        public AbstractAnimal(string name)
        {
            this.Name = name;
            this.Age = 0;
        }

    }
}
