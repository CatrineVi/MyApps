using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = new Cat("Sonya");
            animal.Speak();
            Console.WriteLine($"Имя: {animal.Name}");
            Console.WriteLine($"Возраст: {animal.Age}");
            animal.Eat();
            animal.Drink();
            animal.Die();
        }
    }
}
