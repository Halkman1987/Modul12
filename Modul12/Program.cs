﻿using System;

namespace Modul12
{
    class Programm
    {
        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
        static void Main()
        {
            List<User> users = new List<User>();
            users.Add(new User() { Name = "Dima", IsPremium = false });
            users.Add(new User() { Name = "Petya", IsPremium = false });
            users.Add(new User() { Name = "Vasya", IsPremium = true });
            foreach (User user in users)
            {
                if (user.IsPremium == false)
                {
                    Console.WriteLine($"Hello {user.Name}");
                    ShowAds();
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Hello {user.Name} you have is Premium account");
                    return;
                    Console.WriteLine();
                }
            }
        }
    }
}
