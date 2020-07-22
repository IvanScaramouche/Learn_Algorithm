using System.Collections.Generic;

namespace Algorithm.Selection_Sort {
    public static class SelectionSort {

        public static int[] Sort(List<int> list) {
            var result = new int[list.Count];

            for (int i = 0; i < result.Length; i++) {
                var index = FindSmailElement(list);
                result[i] = list[index];
                list.RemoveAt(index);
            }
            return result;
        }

        private static int FindSmailElement(List<int> list) {
            int smail = list[0];
            int faindIndex = 0;

            for (int i = 0; i < list.Count; i++) {
                if (list[i] < smail) {
                    smail = list[i];
                    faindIndex = i;
                }
            }
            return faindIndex;
        }
    }
}
