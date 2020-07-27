
namespace Algorithm.BreadthFirst_Search {
    class Program {
        static void Main() {

            var You = new Person("You", false);
            var Bob = new Person("Bob", false);
            var Alice = new Person("Alice", false);
            var Claire = new Person("Claire", false);
            var Anju = new Person("Anju", false);
            var Peggy = new Person("Peggy", false);
            var Thom = new Person("Thom", false);
            var Jonny = new Person("Jonny", true);

            You.Friends.AddRange(new[] { Alice, Bob, Claire });
            Bob.Friends.AddRange(new[] { Anju, Peggy });
            Alice.Friends.AddRange(new[] { Peggy });
            Claire.Friends.AddRange(new[] { Thom, Jonny });

            BreadthFirstSearch.Search(You);
        }
    }
}
