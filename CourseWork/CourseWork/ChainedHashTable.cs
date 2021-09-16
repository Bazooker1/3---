using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
        public class HashTable 
        {
            const int max = 6;
            WorkersList[] mass;
            public HashTable()
            {
                mass = new WorkersList[max];
            }
            public int Hash(string key)
            {
                int index = 0;
                while (key.Length != 0)
                {
                    index += (int)key[key.Length - 1];
                    key = key.Substring(0, key.Length - 1);
                }
                index = index % max;
                return index;
            }
            public void Add(Worker data)
            {
                var index = Hash(data.fio);
                mass[index] = new WorkersList();
                mass[index].Add(data);
            }
        public void Clear()
        {
            for (var i = 0; i < max; i++)
            {
                mass[i] = null;
            }
        }
            public Worker Find(string key)
            {
                var index = Hash(key);
                if ((mass[index] != null) && (mass[index].Search(key) != null))
                {
                    return mass[index].Search(key);
                }
                else
                    return null;
            }
            public void Del(Worker data)
            {
                var index = Hash(data.fio);
                if (Find(data.fio) != null)
                {
                    mass[index].Remove(data);
                }
            }
            public void Print()
            {
                for (int i = 0; i < max; i++)
                {
                    if (mass[i] != null)
                    {
                        mass[i].Print();
                        if (mass[i].Count != 0)
                            Console.WriteLine($"Хеш: {i} ");
                    }
                }
            }
        }
        public class Worker : IComparable<Worker>, IEquatable<Worker>
        {
            public string fio;
            public string rodd;
            public Worker(string f, string r)
            {
                fio = f;
                rodd = r;
            }
            public override string ToString()
            {
                return ($"{fio} {rodd}");
            }
            public int CompareTo(Worker other)
            {
                return fio.CompareTo(other.fio);
            }
            public bool Equals(Worker obj)
            {
                return (this.fio == obj.fio && this.rodd == obj.rodd);
            }
        }
        public class DoublyNode
        {
            public DoublyNode(Worker data)
            {
                Data = data;
            }
            public Worker Data { get; set; }
            public DoublyNode Previous { get; set; }
            public DoublyNode Next { get; set; }
        }
        public class WorkersList  // кольцевой двусвязный список
        {
            DoublyNode head; // головной/первый элемент
            int count;  // количество элементов в списке
            public WorkersList()
            {
                head = null;
            }
            // добавление элемента
            public void Add(Worker data)
            {
                DoublyNode node = new DoublyNode(data);

                if (head == null)
                {
                    head = node;
                    head.Next = node;
                    head.Previous = node;
                }
                else
                {
                    node.Previous = head.Previous;
                    node.Next = head;
                    head.Previous.Next = node;
                    head.Previous = node;
                }
                count++;
            }
            public void Print()
            {
                DoublyNode current = head;
                do
                {
                    if (current != null)
                    {
                        Console.Write($"{current.Data} ");
                        current = current.Next;
                    }
                }
                while (current != head);
            }
            public Worker Search(string data)
            {
                DoublyNode current = head;
                do
                {
                    if (current.Data.fio.Equals(data))
                    {
                        return current.Data;
                    }
                    current = current.Next;
                }
                while (current != head);
                return null;
            }
            // удаление элемента
            public bool Remove(Worker data)
            {
                DoublyNode current = head;

                DoublyNode removedItem = null;
                if (count == 0)
                    return false;

                // поиск удаляемого узла
                do
                {
                    if (current.Data.Equals(data))
                    {
                        removedItem = current;
                        break;
                    }
                    current = current.Next;
                }
                while (current != head);

                if (removedItem != null)
                {
                    // если удаляется единственный элемент списка
                    if (count == 1)
                        head = null;
                    else
                    {
                        // если удаляется первый элемент
                        if (removedItem == head)
                        {
                            head = head.Next;
                        }
                        removedItem.Previous.Next = removedItem.Next;
                        removedItem.Next.Previous = removedItem.Previous;
                    }
                    count--;
                    return true;
                }
                return false;
            }
            public int Count { get { return count; } }
            public bool IsEmpty { get { return count == 0; } }

            public void Clear()
            {
                head = null;
                count = 0;
            }

            public bool Contains(Worker data)
            {
                DoublyNode current = head;
                if (current == null) return false;
                do
                {
                    if (current.Data.Equals(data))
                        return true;
                    current = current.Next;
                }
                while (current != head);
                return false;
            }

        }
}
