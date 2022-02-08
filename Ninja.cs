using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Ninja
    {
        private int caloriesEaten;
        public List<Food> FoodHistory;

        public Ninja()
        {
            caloriesEaten = 0;
            FoodHistory = new List<Food>();
        }
        public bool isFull
        {
            get
            {
                return caloriesEaten > 1200;
            }
        }
        public bool Eat(Food meal)
        {
            if(!isFull)
            {
                caloriesEaten += meal.Calories;
                FoodHistory.Add(meal);
                Console.WriteLine($"Ninja is devouring some {meal.Name}");
            }
            else
                Console.WriteLine("Ninja is stuffed!");
            return isFull;
        }
    }
}