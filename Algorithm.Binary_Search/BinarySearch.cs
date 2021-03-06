﻿/*
    * Двоичный (бинарный) поиск
    * 
    * Класический алгоритм поиска элемента в отсортированном масиве,
    * используя дробление массива на половины. 
    * На вход метод поиска получает отсортированный массив числовых переменных,
    * после чего колличество элементов в массиве делется по полам. 
    * Результат деления применяется как индекс для получения элемента из массива.
    * Полученный элемент сравнивается с искомым значением. 
    * Если искоме значение меньше полученного - уменьшаем верхнюю границу поиска до половины
    * Если искомое значение больше - увеличиваем нижнюю границу поиска до половины 
    * И повторяем цикл вновь. 
    * 
*/

namespace Algorithm.Binary_Search {
    public static class BinarySearch {

        public static int? Search(int[] array, int needed) {

            int bottom = 0;
            int top = array.Length - 1;

            while (bottom <= top) {
                int middle = (bottom + top) / 2;
                int guess = array[middle];

                if (guess == needed) {
                    return middle;
                }

                if (guess > needed) {
                    top = middle - 1;
                } else {
                    bottom = middle + 1;
                }
            }

            return null;
        }
    }
}