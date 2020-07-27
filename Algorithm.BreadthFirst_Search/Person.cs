using System.Collections.Generic;

namespace Algorithm.BreadthFirst_Search {
    public class Person {

        public string Name {
            get;
        }

        public bool IsSearch {
            get;
        }

        public List<Person> Friends {
            get; set;
        }

        public Person() {
            Name = default;
            IsSearch = false;
            Friends = new List<Person>();
        }

        public Person(string name, bool isSearch) {
            Name = name;
            IsSearch = isSearch;
            Friends = new List<Person>();
        }
    }
}
