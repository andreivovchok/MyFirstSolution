using System;

namespace MyThreeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int test = 5;
            Console.WriteLine(test.ToString());
            //Можно, если использовать метод ToString. Этот метод возвращает string, который является ссылочным типом.
            //Тогда упаковкане будет происходить.
        }
    }
}
