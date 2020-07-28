using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm.Dijkstras_Algorithm {
    public class Node {

        public string Name {
            get; private set;
        }

        private double cost;
        public double Cost {
            get {
                return cost;
            }
            set {
                cost = (value < 0) ? 0 : value;
            }
        }

        public Dictionary<Node, double> Neighbor {
            get; set;
        }

        public Node Parent {
            get; set;
        }

        public Node() {
            cost = default;
            Neighbor = new Dictionary<Node, double>();
            Parent = default;
        }

        public Node(string name, Node parent, double startCost) {
            this.Name = name;
            cost = startCost;
            Neighbor = new Dictionary<Node, double>();
            Parent = parent;
        }
    }
}
