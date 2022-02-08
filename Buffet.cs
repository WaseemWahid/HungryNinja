using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {
                new Food("Burrito", 900, true, false),
                new Food("Mongolian beef", 900, true, false),
                new Food("Pizza", 850, false, false),
                new Food("Pasta", 750, false, false),
                new Food("Cheesecake", 500, false, true),
                new Food("Cajun Shrimp", 700, true, false),
                new Food("Popeyes Fried Chicken", 1000, true, false)
            };
        }
        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(Menu.Count)];
        }
    }
}