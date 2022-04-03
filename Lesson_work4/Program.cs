using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetFullName("Нестеров", "Владимир", "Алексеевич"));
            Console.WriteLine(GetFullName("Сеницые", "Андрей", "Генадьевич"));
            Console.WriteLine(GetFullName("Манилов", "Александр", "Ветальевич"));
            Console.WriteLine(GetFullName("Лисичкин", "Руслан", "Максимович"));
            Console.ReadLine();
        }
        static string GetFullName(string lastname, string name, string patronymic)
        {
            return $"{lastname} {name} {patronymic}";
        }
    }
}

