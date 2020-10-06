using System;

namespace LinkedList
{
    class LinkedListMain
    {
        static void Main(string[] args)
        {
            var list = new SinglyLinkedList<string>();

            list.AddItem("2323");
            list.AddItem("ABC");
            list.AddItem("gggg");
            list.AddItem("123");
            list.AddItem("ABC");
            list.AddItem("asd");
            list.AddItem("no");

            Console.WriteLine("Список содержит элементы: ");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Первый элемент: ");
            Console.WriteLine(list.GetFirstItem());
            Console.WriteLine();

            list.AddFirstElement("first");
            Console.WriteLine("В начало списка добавлен элемент first: ");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Первый элемент {list.RemoveFirstItem()} удалён из списка: ");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Элементу по индексу {2} вместо {list.SetItemIndex("HHH", 2)} присвоено значение {"HHH"}");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Элемент по индексу {3} равен {list.GetItemIndex(3)}");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Из списка удален элемент {list.RemoveItem(3)} по индексу {3}");
            Console.WriteLine(list);
            Console.WriteLine();

            list.ElementInsert("insert", 4);
            Console.WriteLine($"По индексу {4} был вставлен элемент insert:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Элемент ABC {(list.RemoveNode("ABC") ? "удален" : "отсутствует")}:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine($"Элемент 9999 {(list.RemoveNode("9999") ? "удален" : "отсутствует")}:");
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Разворот списка:");
            list.Revers();
            Console.WriteLine(list);
            Console.WriteLine();

            Console.WriteLine("Копия списка:");
            var copyList = list.Copy();
            Console.WriteLine(copyList);
        }
    }
}
