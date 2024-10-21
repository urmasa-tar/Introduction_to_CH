using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{
    public class combGeneric
    {
        // Генерация всех перестановок
        public static IEnumerable<IEnumerable<T>> Permutations<T>(IEnumerable<T> elements)
        {
            var list = new List<T>(elements);
            int count = list.Count;
            var indices = new int[count];
            for (int i = 0; i < count; i++)
            {
                indices[i] = 0;
            }

            yield return new List<T>(list);

            while (true)
            {
                int i;
                for (i = count - 1; i >= 0; i--)
                {
                    if (indices[i] < i)
                    {
                        int j = (i % 2) == 0 ? 0 : indices[i];
                        Swap(list, i, j);
                        yield return new List<T>(list);
                        indices[i]++;
                        break;
                    }
                    indices[i] = 0;
                }

                if (i < 0) yield break;
            }
        }

        // Генерация всех комбинаций
        public static IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> elements, int k)
        {
            var list = new List<T>(elements);
            int count = list.Count;

            if (k > count)
            {
                yield break;
            }

            int[] indices = new int[k];
            for (int i = 0; i < k; i++)
            {
                indices[i] = i;
            }

            while (true)
            {
                yield return GetCombination(list, indices);

                int position = k - 1;
                while (position >= 0 && indices[position] == count - k + position)
                {
                    position--;
                }

                if (position < 0) yield break;

                indices[position]++;
                for (int i = position + 1; i < k; i++)
                {
                    indices[i] = indices[i - 1] + 1;
                }
            }
        }

        private static IEnumerable<T> GetCombination<T>(List<T> list, int[] indices)
        {
            foreach (var index in indices)
            {
                yield return list[index];
            }
        }

        private static void Swap<T>(List<T> list, int i, int j)
        {
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}
