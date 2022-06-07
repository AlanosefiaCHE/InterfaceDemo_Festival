using System;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var festival = new Festival();
            var map = festival.GetMap();
            Console.WriteLine(map);
        }
    }
}