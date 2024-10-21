using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{
    public class Knapsack
    {
        // Структура для хранения предмета
        public class Item
        {
            public int Value { get; set; }
            public int Weight { get; set; }

            public Item(int value, int weight)
            {
                Value = value;
                Weight = weight;
            }
        }

        // Метод для решения задачи о дробном рюкзаке
        public double FractionalKnapsack(int capacity, List<Item> items)
        {
            // Сортируем предметы по стоимости за единицу веса
            items.Sort((x, y) => (y.Value / (double)y.Weight).CompareTo(x.Value / (double)x.Weight));

            double totalValue = 0;
            foreach (var item in items)
            {
                if (capacity <= 0)
                    break;

                if (item.Weight <= capacity)
                {
                    capacity -= item.Weight;
                    totalValue += item.Value;
                }
                else
                {
                    totalValue += item.Value * ((double)capacity / item.Weight);
                    capacity = 0;
                }
            }

            return totalValue;
        }

        // Метод для решения задачи о 0/1 рюкзаке с использованием динамического программирования
        public int ZeroOneKnapsack(int capacity, List<Item> items)
        {
            int n = items.Count;
            int[,] dp = new int[n + 1, capacity + 1];

            for (int i = 1; i <= n; i++)
            {
                for (int w = 0; w <= capacity; w++)
                {
                    if (items[i - 1].Weight <= w)
                    {
                        dp[i, w] = Math.Max(dp[i - 1, w], dp[i - 1, w - items[i - 1].Weight] + items[i - 1].Value);
                    }
                    else
                    {
                        dp[i, w] = dp[i - 1, w];
                    }
                }
            }

            return dp[n, capacity];
        }

        // Метод для полного перебора (рекурсивное решение)
        public int BruteForceKnapsack(int capacity, List<Item> items, int n)
        {
            // Базовый случай: если не осталось предметов или рюкзак заполнен
            if (n == 0 || capacity == 0)
                return 0;

            // Если вес предмета больше оставшейся вместимости, пропускаем его
            if (items[n - 1].Weight > capacity)
                return BruteForceKnapsack(capacity, items, n - 1);

            // Сравниваем две опции: включение и исключение текущего предмета
            int includeItem = items[n - 1].Value + BruteForceKnapsack(capacity - items[n - 1].Weight, items, n - 1);
            int excludeItem = BruteForceKnapsack(capacity, items, n - 1);

            return Math.Max(includeItem, excludeItem);
        }
    }
}
