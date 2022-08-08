// See https://aka.ms/new-console-template for more information
using System;

namespace SampleConsoleApp
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
            int[,] heights = { { 1, 2, 3 }, { 4, 5, 6 } };
            CreateUser();
            Shop("sampleItem");
            int answer = Curicurate(8999);
            Console.WriteLine(answer);

            Book book1 = new Book();
            book1.name = "C#  practice";
            book1.id = 1;
            Book book2 = new Book();
            book2.name = "C# learning";
            book2.id = 2;

            book1.Buy();
            book2.Name();
        }

        static void CreateUser()
        {
            Console.WriteLine("you have created user propery");
        }

        static void Shop(string itemName)
        {
            Console.WriteLine(itemName);            
        }

        static int Curicurate(int sample)
        {
            int answer;
            answer = sample / 100;
            return answer;
        }
    }
    }