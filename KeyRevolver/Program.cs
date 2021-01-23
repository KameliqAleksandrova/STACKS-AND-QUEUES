using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceBullet = int.Parse(Console.ReadLine());
            int sizeBarrel = int.Parse(Console.ReadLine());
            int[] lineBullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> bullets = new Stack<int>(lineBullets);
            int[] lineLocks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> locks = new Queue<int>(lineLocks);
            int intelligence = int.Parse(Console.ReadLine());
            int counterLocks = 0;
            int counterBullets = 0;
            int bulletsReload = 0;
            while (locks.Any() && bullets.Any())
            {
                if (bulletsReload==sizeBarrel)
                {
                    Console.WriteLine($"Reloading!");
                    bulletsReload = 0;
                }
                int currentBullet = bullets.Pop();
                counterBullets++;
                bulletsReload++;
                int currentLock = locks.Peek();
                if (currentBullet <= currentLock)
                {
                    locks.Dequeue();
                    counterLocks++;
                    Console.WriteLine($"Bang!");
                }
                else
                {
                    Console.WriteLine($"Ping!");
                }
                
            }
            if (bulletsReload == sizeBarrel&& bullets.Any())
            {
                Console.WriteLine($"Reloading!");
                bulletsReload = 0;
            }
            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int leftBullets = lineBullets.Length - counterBullets;
                int resultMoney = intelligence - counterBullets * priceBullet;
                Console.WriteLine($"{leftBullets} bullets left. Earned ${resultMoney}");
            }
        }
    }
}
