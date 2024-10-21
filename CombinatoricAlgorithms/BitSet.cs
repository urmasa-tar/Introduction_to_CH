using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{
    public class BitSet
    {
        private int _bits;

        // Добавление элемента в множество
        public void Add(int value)
        {
            if (value < 0 || value >= 32)
            {
                throw new ArgumentOutOfRangeException("Значение должно быть в диапазоне от 0 до 31.");
            }
            _bits |= (1 << value);
        }

        // Удаление элемента из множества
        public void Remove(int value)
        {
            if (value < 0 || value >= 32)
            {
                throw new ArgumentOutOfRangeException("Значение должно быть в диапазоне от 0 до 31.");
            }
            _bits &= ~(1 << value);
        }

        // Проверка, находится ли элемент в множестве
        public bool Contains(int value)
        {
            if (value < 0 || value >= 32)
            {
                throw new ArgumentOutOfRangeException("Значение должно быть в диапазоне от 0 до 31.");
            }
            return (_bits & (1 << value)) != 0;
        }

        // Отображение элементов множества
        public void PrintSet()
        {
            Console.Write("Элементы множества: ");
            for (int i = 0; i < 32; i++)
            {
                if (Contains(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
