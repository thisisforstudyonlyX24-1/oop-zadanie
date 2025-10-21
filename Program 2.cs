using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        class Phone
        {
            private string brand;
            private int batteryLevel;

            public string phoneBrand
            {
                get { return brand; }
                set { brand = value; }
            }

            public int phoneBatteryLevel
            {
                get { return batteryLevel; }
                set { batteryLevel = value; }
            }

            public Phone(string brand, int batteryLevel)
            {
                phoneBrand = brand;
                phoneBatteryLevel = batteryLevel;
            }

            public void UsePhone()
            {
                if (phoneBatteryLevel - 10 < 0)
                {
                    Console.WriteLine("Заряд не может опуститься меньше 0");
                }
                else
                {
                    phoneBatteryLevel -= 10;
                }
                Console.WriteLine($"Телефон {phoneBrand}, заряд: {batteryLevel}%");
            }
        }
        static void Main(string[] args)
        {
            Phone newPhone = new Phone("", 0);

            Console.Write("Введите бренд: ");
            string input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) newPhone.phoneBrand = input;
            else
            {
                Console.WriteLine("Ошибка: Строка пуста или состоит только из пробелов");
                return;
            }

            Console.Write("Введите уровень заряда: ");
            if (int.TryParse(Console.ReadLine(), out int phoneBatteryLevel) && phoneBatteryLevel >= 0 && phoneBatteryLevel <= 100) newPhone.phoneBatteryLevel = phoneBatteryLevel;
            else
            {
                Console.WriteLine("Заряд должен быть от 0 до 100.");
                return;
            }
            newPhone.UsePhone();
        }
    }
}