using System;
using System.Collections.Generic;
using System.Globalization;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many employees will be registered ? ");
            int number = int.Parse(Console.ReadLine());

            List<Empregados> list = new List<Empregados>();

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Emplyoee #" + i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Empregados(name, salary, id));
            }

            Console.WriteLine();
            Console.Write("Enter the employee id that will have salary increase: ");
            int empId = int.Parse(Console.ReadLine());

            Empregados list2 = list.Find(x => x.Id == empId);

            if (list2 != null)
            {
                Console.Write("Enter the percentage: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list2.Increase(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
