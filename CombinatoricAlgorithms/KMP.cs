using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{

    public class KMP
    {
        private readonly string pattern;
        private readonly int[] lps;

        public KMP(string pattern)
        {
            this.pattern = pattern;
            lps = BuildLPS(pattern);
        }

        // Метод для построения массива lps (Longest Prefix which is also Suffix)
        private int[] BuildLPS(string pattern)
        {
            int length = 0; // Длина предыдущего самого длинного префикса
            int m = pattern.Length;
            int[] lps = new int[m];
            lps[0] = 0; // lps[0] всегда равно 0

            for (int i = 1; i < m; i++)
            {
                while (length > 0 && pattern[i] != pattern[length])
                {
                    length = lps[length - 1];
                }

                if (pattern[i] == pattern[length])
                {
                    length++;
                    lps[i] = length;
                }
                else
                {
                    lps[i] = 0;
                }
            }

            return lps;
        }

        // Метод для поиска подстроки в строке
        public void Search(string text)
        {
            int n = text.Length;
            int m = pattern.Length;
            int i = 0; // Индекс для text
            int j = 0; // Индекс для pattern

            while (i < n)
            {
                if (pattern[j] == text[i])
                {
                    i++;
                    j++;
                }

                if (j == m)
                {
                    Console.WriteLine("Подстрока найдена в индексе: " + (i - j));
                    j = lps[j - 1]; // Продолжаем искать другие совпадения
                }
                else if (i < n && pattern[j] != text[i])
                {
                    // Мismatch после j совпадений
                    if (j != 0)
                    {
                        j = lps[j - 1];
                    }
                    else
                    {
                        i++;
                    }
                }
            }
        }
    }
}
