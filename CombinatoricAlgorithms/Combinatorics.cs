using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{
    public class Combinatorics
    {
        // Вычисляет факториал числа n (n!)
        public long Factorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(n), "Факториал не определен для отрицательных чисел.");
            }
            else if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                long result = 1;
                for (int i = 2; i <= n; i++)
                {
                    result *= i;
                }
                return result;
            }
        }

        // Вычисляет количество перестановок n элементов (n!)
        public long Permutations(int n)
        {
            return Factorial(n);
        }

        // Вычисляет количество комбинаций из n элементов по k (C(n, k))
        public long Combinations(int n, int k)
        {
            if (k < 0 || k > n)
            {
                return 0;
            }
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }

        // Вычисляет количество размещений из n элементов по k (A(n, k))
        public long Arrangements(int n, int k)
        {
            if (k < 0 || k > n)
            {
                return 0;
            }
            return Factorial(n) / Factorial(n - k);
        }
    }
}
