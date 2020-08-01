/*
 *  Жадные алгоритмы
 * 
 * Алгоритм, который на каждом шагу делает локально наилучший выбор в надежде, что итоговое решение будет оптимальным.
 * 
 */


using System.Collections.Generic;
using System.Linq;

namespace Algorithm.Greedy_Algorithms {
    public static class GreedyAlgorithms {

        public static List<string> Search(Dictionary<string, List<string>> stations, HashSet<string> states) {
            var finalStation = new List<string>();

            while (states.Any()) {
                string bestStation = null;
                var statesCovered = new List<string>();

                foreach (var station in stations) {
                    var covered = new List<string>(states.Intersect(station.Value));
                    if (covered.Count > statesCovered.Count) {
                        bestStation = station.Key;
                        statesCovered = covered;
                    }
                }

                states.RemoveWhere(s => statesCovered.Contains(s));
                finalStation.Add(bestStation);
            }
            return finalStation;
        } 
    }
}
