using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        class Pet
        {
            private string name;
            private int energy;
            public Pet(string Name, int Energy)
            {
                name = Name;
                energy = Energy;
            }
            public void Play()
            {
                if (energy - 20 >= 0)
                {
                    energy -= 20;
                    Console.WriteLine($"{name} играет, энергия: {energy}");
                }
                else
                {
                    Console.WriteLine("Энергия питомца не может опуститься ниже 0.");
                    return;
                }
            }
            public void Rest()
            {
                if (energy + 30 <= 100)
                {
                    energy += 30;
                    Console.WriteLine($"{name} отдыхает, энергия: {energy}");
                }
                else
                {
                    Console.WriteLine("Энергия питомца не может быть больше 100.");
                    return;
                }
            }
            public string petName
            {
                set { name = value; }
                get { return name; }
            }
            public int petEnergy
            {
                set { energy = value; }
                get { return energy; }
            }

            static void Main(string[] args)
            {
                Pet newPet = new Pet("", 0);

                Console.Write("Введите имя питомца: ");
                string input = Console.ReadLine();
                newPet.petName = input;
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Ошибка. Строка пуста либо содержит только пробелы.");
                    return;
                }

                Console.Write("Введите количество энергии питомца (от 0 до 100): ");
                if (!int.TryParse(Console.ReadLine(), out int num) || num < 0 || num > 100)
                {
                    Console.WriteLine("Количество энергии должно быть в диапозоне (0-100)");
                    return;
                }
                newPet.petEnergy = num;
                newPet.Play();
                newPet.Rest();
            }
        }
    }
}