using System;
using System.Text;

namespace LinkedList
{
    class SinglyLinkedList<T>
    {
        private LinkedListItem<T> head;
        private int Count { get; set; }

        //получение размера списка
        public int GetCount()
        {
            return Count;
        }

        //получение значения первого элемента
        public T GetFirstItem()
        {
            if (head == null)
            {
                throw new NullReferenceException("Пустой список!");
            }

            return head.Data;
        }

        //удаление первого элемента, пусть выдает значение элемента
        public T RemoveFirstItem()
        {
            if (head == null)
            {
                throw new NullReferenceException("Пустой список!");
            }

            var remoteElement = head.Data;
            head = head.Next;
            Count--;

            return remoteElement;
        }

        public LinkedListItem<T> GetItem(int index)
        {
            var item = head;

            for (int i = 0; i < index; i++)
            {
                item = item.Next;
            }

            return item;
        }

        //получение значения по указанному индексу
        public T GetItemIndex(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Индекс за границами списка!");
            }

            var item = GetItem(index);

            return item.Data;
        }

        //изменение значения по указанному индексу. Изменение значения по индексу пусть выдает старое значение.
        public T SetItemIndex(T data, int index)
        {
            var item = GetItem(index);
            var oldData = item.Data;

            item.Data = data;

            return oldData;
        }

        public void AddItem(T data)
        {
            var newItem = new LinkedListItem<T>(data);

            if (head == null)
            {
                head = newItem;
            }
            else
            {
                GetItem(Count - 1).Next = newItem;
            }

            Count++;
        }

        //вставка элемента в начало
        public void AddFirstElement(T data)
        {
            var item = new LinkedListItem<T>(data);

            if (Count != 0)
            {
                item.Next = head;
            }

            head = item;
            Count++;
        }

        //вставка элемента по индексу
        public void ElementInsert(T data, int index)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException("Индекс за границами списка!");
            }

            if (index == 0)
            {
                AddFirstElement(data);
                return;
            }

            if (index == Count)
            {
                AddItem(data);
                return;
            }

            var item = GetItem(index - 1);

            var newItem = new LinkedListItem<T>(data)
            {
                Next = item.Next
            };

            item.Next = newItem;
            Count++;
        }

        //удаление элемента по индексу, пусть выдает значение элемента
        public T RemoveItem(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new ArgumentOutOfRangeException("Индекс за границами списка!");
            }

            if (index == 0)
            {
                return RemoveFirstItem();
            }

            var item = GetItem(index - 1);

            var oldData = item.Next.Data;
            item.Next = item.Next.Next;

            Count--;

            return oldData;
        }

        //удаление узла по значению, пусть выдает true, если элемент был удален
        public bool RemoveNode(T data)
        {
            if (Count == 0)
            {
                return false;
            }

            var item = head;

            for (int i = 0; i < Count; i++)
            {
                if (Equals(data, item.Data))
                {
                    RemoveItem(i);

                    return true;
                }

                item = item.Next;
            }

            return false;
        }

        //разворот списка за линейное время
        public void Revers()
        {
            if (head == null)
            {
                return;
            }

            var item = head;
            LinkedListItem<T> previousItem = null;

            while (item != null)
            {
                var temp = item.Next;
                item.Next = previousItem;
                previousItem = item;
                item = temp;
            }

            head = previousItem;
        }

        //копирование списка
        public SinglyLinkedList<T> Copy()
        {
            var copyList = new SinglyLinkedList<T>();

            if (head == null)
            {
                return copyList;
            }

            var item = head;

            var newItem = new LinkedListItem<T>(item.Data);
            copyList.head = newItem;

            while (item.Next != null)
            {
                newItem.Next = new LinkedListItem<T>(item.Next.Data);
                newItem = newItem.Next;
                item = item.Next;
            }

            copyList.Count = Count;

            return copyList;
        }

        public override string ToString()
        {
            if (head == null)
            {
                return "{ }";
            }

            var item = head;
            var newString = new StringBuilder();
            const string separator = ", ";

            newString.Append(item.Data);

            for (int i = 0; i < Count - 1; i++)
            {
                item = item.Next;
                newString.Append(separator);
                newString.Append(item.Data);
            }

            return newString.ToString();
        }
    }
}