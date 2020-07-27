/*
 *  Поиск в ширину
 *  
 *  Метод помещает начальный узел в очередь
 *  Извлекает из начала очереди узел и проверяет его на соответствие искомого условия
 *  Если узелл соответствует условию, то поиск завершается успешно
 *  Если нет, то в конец очереди добавляются узлы, связанные с рассматриваемым узлом
 *  Узлы извлекаются из очереди и помечаются, как просмотренные до тех пор,
 *  Пока не будет найден искомый узел или очередь не станет пустой
 * 
 */

using System.Collections.Generic;
using System.Linq;
using System;

namespace Algorithm.BreadthFirst_Search {
    public static class BreadthFirstSearch {

        public static bool Search(Person startPerson) {
            var queue = new Queue<Person>(startPerson.Friends);
            var searched = new List<Person>();

            while (queue.Any()) {
                var person = queue.Dequeue();
                if (!searched.Contains(person)) {
                    if (person.IsSearch) {
                        Console.WriteLine($"{person.Name} is a mango seller.");
                        return true;
                    } else {
                        queue = new Queue<Person>(queue.Concat(person.Friends));
                        searched.Add(person);
                    }
                }
            }

            return false;
        }
    }
}
