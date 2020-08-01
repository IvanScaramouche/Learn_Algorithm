using System;
using System.Collections.Generic;

namespace Algorithm.Greedy_Algorithms {
    class Program {
        static void Main() {
            var states = new HashSet<string> { "mt", "wa", "or", "id", "nv", "ut", "ca", "az" };
            var stations = new Dictionary<string, List<string>>();

            stations.Add("kone", new List<string> { "id", "nv", "ut" });
            stations.Add("ktwo", new List<string> { "wa", "id", "mt" });
            stations.Add("kthree", new List<string> { "or", "nv", "ca" });
            stations.Add("kfour", new List<string> { "nv", "ut" });
            stations.Add("kfive", new List<string> { "ca", "az" });

            var result = GreedyAlgorithms.Search(stations, states);

            Console.WriteLine("Result: ");
            foreach (var station in result) {
                Console.WriteLine(station);
            }
        }
    }
}
