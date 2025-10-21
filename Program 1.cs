using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Person
        {
            private string name;
            private int age;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set { age = value; }
            }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void SayHello()
            {
                Console.WriteLine($"Привет, я {Name}, мне {Age} лет!");
            }
        }
        static void Main(string[] args)
        {
            Person newPerson = new Person("", 0);
            Console.Write("Введите имя: ");
            string str = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(str))
            {
                newPerson.Name = str;
            }
            else
            {
                Console.WriteLine("Ошибка: строка пустая или содержит только пробелы");
                return;
            }

            Console.Write("Введите возраст: ");
            if (int.TryParse(Console.ReadLine(), out int userAge) && userAge >= 0 && userAge <= 120)
            {
                newPerson.Age = userAge;
            }
            else
            {
                Console.WriteLine("Возраст должен быть от 0 до 120.");
                return;
            }
            newPerson.SayHello();
        }
    }
}
