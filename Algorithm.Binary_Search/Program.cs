using System;

namespace Algorithm.Binary_Search {
    class Program {
        static void Main() {
            int[] array = {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20
            };

            int searchElement = 14;
            int? result = BinarySearch.Search(array, searchElement);

            if (result is null) {
                Console.WriteLine($"Искомый элемент {searchElement} в масииве не найден.");
            } else {
                Console.WriteLine($"Искомый элемент {searchElement} находится по индексу: {result}");
            }
        }
    }
}
