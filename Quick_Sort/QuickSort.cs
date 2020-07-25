/*
 * Быстрая сортировка
 * 
 * Алгоритм сортировки основанный на стратегии "разделяй и властвуй".
 * Он так же оснвоан на использовании рекурсивной функции.
 * В массиве элементов выберается ключевой элемент, от которого массив делится на два массива
 * Один (левый) массив сотержит элементы которые меньше опорного числа
 * Второй (правый) элементы которые больше опорного числа
 * Операция повторяется для каждого из подмассивов, пока в каждом массиве не останется по одному элементу
 * 
 */


using System.Collections.Generic;
using System.Linq;

namespace Quick_Sort {
    public static class QuickSort {
        public static List<int> Sort(List<int> list) {
            if (list.Count <= 1) {
                return list;
            }
            var pivot = list.First();
            List<int> less = list.Skip(1).Where(i => i <= pivot).ToList();
            List<int> greater = list.Skip(1).Where(i => i > pivot).ToList();

            return Sort(less).Union(new List<int> { pivot }).Union(Sort(greater)).ToList();
        }
    }
}
