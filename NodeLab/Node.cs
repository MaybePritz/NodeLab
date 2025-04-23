using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NodeLab
{
    public class Node
    {
        private int info;
        private Node link;

        public int Info { get; set; }
        public Node Link { get; set; }

        public Node() { }
        public Node(int info) { Info = info; }
        public Node(int info, Node link) { Info = info; Link = link; }
    }

    public class SingleLinkedList
    {
        private Node first;

        public SingleLinkedList() { first = null; }

        public void InsertBeforeFirst(int data)
        {
            Node p = new Node(data, first);
            first = p;
        }

        public void InsertLast(int data)
        {
            Node p = new Node(data);

            if (first != null)
            {
                Node last = first;

                while (last.Link != null)
                {
                    last = last.Link;
                }

                last.Link = p;

            }
            else
            {
                first = p;
            }
        }

        public void InsertCustom(int data, int position, out string errorMessage)
        {
            errorMessage = "";
            Node newNode = new Node(data);

            if (position < 0)
            {
                errorMessage = "Неверная позиция";
            }
            else
            {
                if (position == 0)
                {
                    InsertBeforeFirst(data);
                }
                else
                {
                    if (first == null)
                    {
                        errorMessage = "Список пуст, позиция вне диапазона";
                    }
                    else
                    {
                        Node current = first;
                        int index = 0;

                        while (index < position - 1 && current.Link != null)
                        {
                            current = current.Link;
                            index++;
                        }

                        if (index < position - 1)
                        {
                            errorMessage = "Вы вышли за пределы!";
                        }
                        else
                        {
                            newNode.Link = current.Link;
                            current.Link = newNode;
                        }
                    }
                }
            }
        }



        public void Create_1(int[] data)
        {
            first = null;

            for (int i = 0; i < data.Length; i++)
            {
                Node p = new Node(data[i], first);
                first = p;
            }
        }

        public void Create_2(int[] data)
        {
            first = new Node(data[0]);
            Node last = first;

            for (int i = 1; i < data.Length; i++)
            {
                Node p = new Node(data[i]);
                last.Link = p;
                last = p;
            }
        }

        public void DeleteFirst1()
        {
            if (first != null)
            {
                first = first.Link;
            }
        }

        public Node DeleteFirst2()
        {
            Node p = first;

            if (first != null)
            {
                first = first.Link;
            }

            return p;
        }

        public void DeleteLast()
        {
            if(first != null)
            {
                if(first.Link != null)
                {
                    Node p = first;

                    while (p.Link.Link != null)
                    {
                        p = p.Link;
                    }
                    p.Link = null;
                }
                else
                {
                    first = null;
                }
            }
        }

        public void DeleteCustom(int position, out string errorMessage)
        {
            errorMessage = "";

            if (position < 0)
            {
                errorMessage = "Неверная позиция";
            }
            else
            {
                if (first == null)
                {
                    errorMessage = "Список пуст, позиция вне диапазона";
                }
                else
                {
                    if (position == 0)
                    {
                        DeleteFirst1();
                    }
                    else
                    {
                        Node current = first;
                        int index = 0;
                        while (index < position - 1 && current.Link != null)
                        {
                            current = current.Link;
                            index++;
                        }

                        if (current.Link == null)
                        {
                            errorMessage = "Вы вышли за пределы!";
                        }
                        else
                        {
                            current.Link = current.Link.Link;
                        }
                    }
                }
                
            }
            
        }



        public int Count()
        {
            Node p = first;
            int count = 0;

            while (p != null)
            {
                count++;
                p = p.Link;
            }

            return count;
        }

        public bool IsSorted()
        {
            bool isSorted = true;

            if (first == null || first.Link == null) isSorted = true;

            Node p = first;

            while (p.Link != null && isSorted && p != null)
            {
                if (p.Info > p.Link.Info) isSorted = false;
                p = p.Link;
            }

            return isSorted;
        }

        public Node Find(int value)
        {
            Node p = first;
            while ((p != null) && (p.Info != value))
            {
                p = p.Link;
            }
            return p;
        }

        public void InsertAfter(Node p, int data)
        {
            if (p != null)
            {
                Node q = new Node(data);

                q.Link = p.Link;
                p.Link = q;
            }
        }

        public void DeleteAfter1(Node p)
        {
            if (p != null && p.Link != null)
            {
                p.Link = p.Link.Link;
            }
        }

        public Node DeleteAfter2(Node p)
        {
            Node q = null;

            if (p != null && p.Link != null)
            {
                q = p.Link;
                p.Link = q.Link;
            }

            return q;
        }

        public void Delete(ref Node p)
        {
            if (p != null && first != null)
            {
                if (p == first)
                {
                    first = first.Link;
                }
                else
                {
                    Node q = first;

                    while (q != null && q.Link != p)
                    {
                        q = q.Link;
                    }

                    q.Link = p.Link;
                }
            }
            p = null;
        }

        public void DeleteBetween(int value1, int value2, out string errorMessage)
        {
            Node left = Find(value1);
            errorMessage = "";

            if (left != null)
            {
                Node right = Find(value2);

                if (right != null)
                {
                    Node p = left.Link;
                    bool isCorrect = false;

                    while (p != null && !isCorrect)
                    {
                        if (p == right)
                        {
                            isCorrect = true;
                        }
                        p = p.Link;
                    }

                    if (isCorrect)
                    {
                        if (left.Link != right)
                        {
                            left.Link = right;
                        }
                        else
                        {
                            errorMessage = "Между границами нет элементов";
                        }
                    }
                    else
                    {
                        errorMessage = "Правая граница должна находиться после левой";
                    }
                }
                else
                {
                    errorMessage = "Правая граница не найдена";

                }
            }
            else
            {
                errorMessage = "Левая граница не найдена";
            }
        }

        public void Destroy()
        {
            first = null;
        }

        public string Print()
        {
            string result = "";
            Node p = first;

            while (p != null)
            {
                result += p.Info;
                p = p.Link;
                if (p != null)
                    result += " -> ";
            }

            return result;
        }

        public void PrintListBox(ListBox listBox)
        {
            listBox.Items.Clear();
            Node current = first;
            while (current != null)
            {
                listBox.Items.Add(current.Info);
                current = current.Link;
            }
        }

    }
}
