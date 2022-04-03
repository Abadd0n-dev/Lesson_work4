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
            string output = StringOutput();
            int spacereturns = linebreak(output);
            Console.WriteLine(spacereturns);
            Console.ReadLine();
        }
        static string StringOutput()
        {
            Console.Write("Введите последовательность чисел через пробел: ");
            return Console.ReadLine();
        }
        static int linebreak(string output)
        {
            var words = output.Split();
            int part = default;
            for (int i = 0; i < words.Length; part += int.Parse(words[i++])) ;
            return part;
        }
    }
}
