﻿namespace _2._A_Miner_Task
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<string, uint> resourceMap = new Dictionary<string, uint>();

            string resource;
            while ((resource = Console.ReadLine()) != "stop")
            {
                if (!resourceMap.ContainsKey(resource))
                {
                    resourceMap.Add(resource, 0);
                }

                uint quantity = uint.Parse(Console.ReadLine());
                resourceMap[resource] += quantity;
            }

            foreach (var resourcePair in resourceMap)
            {
                Console.WriteLine($"{resourcePair.Key} -> {resourcePair.Value}");
            }
        }
    }
}