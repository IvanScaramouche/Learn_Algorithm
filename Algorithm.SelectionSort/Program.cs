using System.Collections.Generic;
using System;

namespace Algorithm.Selection_Sort {
    class Program {
        static void Main() {
            var list = new List<int>() {
                1, 6, 5, 13, 22, 8, 9, 13, 44, 2, 10, 17, 25, 4, 3, 7, 0, -3, 33
            };

            Console.WriteLine("Неотсортированный список: ");
            foreach (int i in list) {
                Console.Write($"{i}, ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Сортируем список.");
            Console.WriteLine();

            int[] sortArray = SelectionSort.Sort(list.ToArray());
            Console.WriteLine("Отсортированный список: ");
            foreach (int i in sortArray) {
                Console.Write($"{i}, ");
            }
            Console.WriteLine();
        }
    }
}
