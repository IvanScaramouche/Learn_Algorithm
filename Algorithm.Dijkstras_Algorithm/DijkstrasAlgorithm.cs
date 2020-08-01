/*
 *  Алгоритм Дейкстры
 *
 *  Алгоритм находит кратчайшие пути от одной из вершин графа до всех остальных. 
 *  Алгоритм работает только для ацикличных направленных графов без рёбер отрицательного веса 
 * 
 */

using System.Collections.Generic;
using System;

namespace Algorithm.Dijkstras_Algorithm {
    public static class DijkstrasAlgorithm {

        private static List<Node> processed = new List<Node>();

        public static void Search(Node startNode, Node finishNode, List<Node> graph) {
            var node = startNode;
            node.Cost = 0;

            while (!(node is null)) {
                var cost = node.Cost;
                var neighbors = node.Neighbor;

                foreach (var neighbor in neighbors) {
                    var newCost = cost + neighbor.Value;
                    if (newCost < neighbor.Key.Cost) {
                        neighbor.Key.Cost = newCost;
                        neighbor.Key.Parent = node;
                    }
                }
                processed.Add(node);
                node = FindLowestCostNode(graph);
            }

            node = finishNode;
            while (!(node is null)) {
                Console.WriteLine($"{node.Name}");
                node = node.Parent;
            }
        }

        private static Node FindLowestCostNode(List<Node> graph) {

            var lowestCost = double.PositiveInfinity;
            Node lowestCostNode = default;

            foreach (var node in graph) {
                var cost = node.Cost;
                if (cost < lowestCost && !processed.Contains(node)) {
                    lowestCost = cost;
                    lowestCostNode = node;
                }
            }

            return lowestCostNode;
        }
    }
}
