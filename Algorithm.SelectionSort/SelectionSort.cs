/*
 *  Сортировка выбором
 *  
 *  В неотсортированном масиве ищем минимальный элемент.
 *  Найденный минимальный элемент меняем местами с последним элементом в массиве.
 *  Если ещё остались неотсортированные элементы - повторяем посик. 
 *  
*/

namespace Algorithm.Selection_Sort {
    public static class SelectionSort {

        public static int[] Sort(int[] list) {
            int down = 0;
            for (int i = 0; i < list.Length - 1; i++) {
                down = i;
                for (int j = i + 1; j < list.Length; j++) {
                    if (list[j] < list[down]) {
                        down = j;
                    }
                }

                if (i != down) {
                    Swap(list, i, down);
                }
            }

            return list;
        }

        private static void Swap(int[] array, int first, int second) {
            int temp = array[second];
            array[second] = array[first];
            array[first] = temp;
        }
    }
}
