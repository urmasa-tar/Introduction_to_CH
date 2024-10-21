using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinatoricAlgorithms
{
    public class GeneticAlgorithm
    {
        private Random _random = new Random();
        private int _populationSize;
        private double _mutationRate;
        private List<City> _cities;

        public GeneticAlgorithm(List<City> cities, int populationSize, double mutationRate)
        {
            _cities = cities;
            _populationSize = populationSize;
            _mutationRate = mutationRate;
        }

        public List<City> Run(int generations)
        {
            // Создание начальной популяции
            List<List<City>> population = InitializePopulation();

            for (int i = 0; i < generations; i++)
            {
                // Оценка и сортировка популяции
                population = EvaluatePopulation(population);
                List<List<City>> newPopulation = new List<List<City>>();

                // Сохранение лучших решений
                newPopulation.Add(population.First());

                // Кроссоверы и мутации
                while (newPopulation.Count < _populationSize)
                {
                    List<City> parent1 = SelectParent(population);
                    List<City> parent2 = SelectParent(population);
                    List<City> child = Crossover(parent1, parent2);
                    Mutate(child);
                    newPopulation.Add(child);
                }

                population = newPopulation;
            }

            return population.First(); // Возвращаем лучшее решение
        }

        private List<List<City>> InitializePopulation()
        {
            var population = new List<List<City>>();
            for (int i = 0; i < _populationSize; i++)
            {
                var individual = _cities.OrderBy(c => _random.Next()).ToList(); // Случайная последовательность городов
                population.Add(individual);
            }
            return population;
        }

        private List<List<City>> EvaluatePopulation(List<List<City>> population)
        {
            return population.OrderBy(c => CalculateDistance(c)).ToList(); // Сортируем по расстоянию
        }

        private double CalculateDistance(List<City> route)
        {
            double distance = 0;
            for (int i = 0; i < route.Count - 1; i++)
            {
                distance += GetDistance(route[i], route[i + 1]);
            }
            // Возвращаем в исходный город
            distance += GetDistance(route.Last(), route.First());
            return distance;
        }

        private double GetDistance(City city1, City city2)
        {
            return Math.Sqrt(Math.Pow(city1.X - city2.X, 2) + Math.Pow(city1.Y - city2.Y, 2));
        }

        private List<City> SelectParent(List<List<City>> population)
        {
            // Селектор на основе рулетки
            int totalDistance = population.Sum(p => (int)CalculateDistance(p));
            double randomValue = _random.NextDouble() * totalDistance;

            foreach (var individual in population)
            {
                randomValue -= CalculateDistance(individual);
                if (randomValue <= 0)
                    return individual;
            }

            return population.Last(); // На всякий случай
        }

        private List<City> Crossover(List<City> parent1, List<City> parent2)
        {
            var child = new List<City>(new City[parent1.Count]);
            int start = _random.Next(0, parent1.Count);
            int end = _random.Next(start, parent1.Count);

            for (int i = start; i < end; i++)
            {
                child[i] = parent1[i];
            }

            int parent2Index = 0;
            for (int i = 0; i < child.Count; i++)
            {
                if (child[i] == null)
                {
                    while (child.Contains(parent2[parent2Index]))
                    {
                        parent2Index++;
                    }
                    child[i] = parent2[parent2Index];
                }
            }

            return child;
        }

        private void Mutate(List<City> individual)
        {
            for (int i = 0; i < individual.Count; i++)
            {
                if (_random.NextDouble() < _mutationRate)
                {
                    int j = _random.Next(individual.Count);
                    // Меняем местами два города
                    City temp = individual[i];
                    individual[i] = individual[j];
                    individual[j] = temp;
                }
            }
        }
    }
}
