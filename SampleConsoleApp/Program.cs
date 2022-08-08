// See https://aka.ms/new-console-template for more information
using System;
namespace User
    {
    class User
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int money;
            string name;

            money = 500;
            name = "kitakura";
            Console.WriteLine(money);
            Console.WriteLine(name);
            float[] weights;
            weights = new float[7];
            for (int i = 0; i < weights.Length; i++) {
                weights[i] = i;
                Console.WriteLine(weights[i]);
            }
        }
    }
    }