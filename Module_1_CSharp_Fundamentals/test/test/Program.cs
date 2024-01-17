using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
        Dictionary<string, int> unlikedMealsCount = new Dictionary<string, int>();

        string input;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] command = input.Split('-');

            switch (command[0])
            {
                case "Like":
                    LikeMeal(likedMeals, command[1], command[2]);
                    break;

                case "Dislike":
                    DislikeMeal(likedMeals, unlikedMealsCount, command[1], command[2]);
                    break;
            }
        }

        PrintLikedMeals(likedMeals);
        PrintUnlikedMealsCount(unlikedMealsCount);
    }

    static void LikeMeal(Dictionary<string, List<string>> likedMeals, string guest, string meal)
    {
        if (!likedMeals.ContainsKey(guest))
        {
            likedMeals.Add(guest, new List<string>());
        }

        if (!likedMeals[guest].Contains(meal))
        {
            likedMeals[guest].Add(meal);
        }
    }

    static void DislikeMeal(Dictionary<string, List<string>> likedMeals, Dictionary<string, int> unlikedMealsCount, string guest, string meal)
    {
        if (likedMeals.ContainsKey(guest))
        {
            if (likedMeals[guest].Contains(meal))
            {
                likedMeals[guest].Remove(meal);
                UpdateUnlikedMealsCount(unlikedMealsCount, meal);
                Console.WriteLine($"{guest} doesn't like the {meal}.");
            }
            else
            {
                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
            }
        }
        else
        {
            Console.WriteLine($"{guest} is not at the party.");
        }
    }

    static void UpdateUnlikedMealsCount(Dictionary<string, int> unlikedMealsCount, string meal)
    {
        if (!unlikedMealsCount.ContainsKey(meal))
        {
            unlikedMealsCount.Add(meal, 0);
        }

        unlikedMealsCount[meal]++;
    }

    static void PrintLikedMeals(Dictionary<string, List<string>> likedMeals)
    {
        foreach (var pair in likedMeals)
        {
            string guest = pair.Key;
            List<string> meals = pair.Value;

            if (meals.Count > 0)
            {
                Console.WriteLine($"{guest}: {string.Join(", ", meals)}");
            }
            else
            {
                Console.WriteLine($"{guest}:");
            }
        }
    }

    static void PrintUnlikedMealsCount(Dictionary<string, int> unlikedMealsCount)
    {
        Console.WriteLine($"Unliked meals: {unlikedMealsCount.Values.Sum()}");
    }
}
