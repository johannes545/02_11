using System;

namespace excercise_02_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string age = Console.ReadLine();
            string favoritePie = Console.ReadLine();
            string favoriteBook = Console.ReadLine();

            string user = name + age + favoritePie + favoriteBook;

            Console.WriteLine(user);

            
        }
    }
}
