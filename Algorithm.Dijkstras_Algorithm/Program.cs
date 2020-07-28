using System;
using System.Collections.Generic;

namespace Algorithm.Dijkstras_Algorithm {
    class Program {
        static void Main() {
            const double INFINITY = double.PositiveInfinity;

            Node start = new Node("start", default, 0.0);
            Node nodeA = new Node("A", default, INFINITY);
            Node nodeC = new Node("C", default, INFINITY);
            Node nodeB = new Node("B", default, INFINITY);
            Node nodeY = new Node("Y", default, INFINITY);
            Node finish = new Node("finish", default, INFINITY);

            start.Neighbor.Add(nodeA, 6.0);
            start.Neighbor.Add(nodeB, 2.0);
            nodeA.Neighbor.Add(nodeC, 1.0);
            nodeC.Neighbor.Add(finish, 2.0);
            nodeB.Neighbor.Add(nodeA, 3.0);
            nodeB.Neighbor.Add(nodeY, 2.0);
            nodeY.Neighbor.Add(finish, 1.0);

            List<Node> graph = new List<Node>() {
                start, nodeA, nodeC, nodeB, nodeY, finish
            };

            DijkstrasAlgorithm.Search(start, finish, graph);
        }
    }
}
