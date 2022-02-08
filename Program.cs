using System;

namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Ninja ninja = new Ninja();
            Buffet buffet = new Buffet();

            while(!ninja.isFull)
            {
                ninja.Eat(buffet.Serve());
                ninja.Eat(buffet.Serve());
                ninja.Eat(buffet.Serve());
            }
        }
    }
}
