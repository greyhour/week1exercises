using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    public class animal
    {
        public int ID { get; }
        public string Name { get; }
        public string Type { get; }
        public int Age { get; }

        public animal(int id, string name, string type, int age)
        {
            ID = id;
            Name = name;
            Type = type;
            Age = age;
        }

        public string returnAnimal()
        {
            return "ID: " + ID + ", Name: " + Name + ", Type: " + Type + ", Age: " + Age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many animals do you want to create: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            animal[] animals = new animal[amount];

            for (int i = 0; i < amount; i++)
            {
                int id = i + 1;
                Console.WriteLine("--------" + id + "--------");
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Type: ");
                string type = Console.ReadLine();
                Console.WriteLine("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                animals[i] = new animal(id, name, type, age);
            }

            Console.WriteLine("--Animals Created--");
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(animals[i].returnAnimal());
            }
            Console.ReadLine();
        }
    }
}
