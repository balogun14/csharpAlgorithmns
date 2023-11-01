using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DsaProblems
{
    public class Node
    {
        public int data;
        public Node? next;
    }
    public class HashTableWithQuadraticProbing
    {
        static int Size = 7;
        Node[] chain = new Node[Size];

        public HashTableWithQuadraticProbing()
        {
            int i;
            for (i = 0; i < Size; i++)
            {
                chain[i] = null!;
            }
        }

        public void Insert(int value)
        {
            Node newNode = new()
            {
                data = value,
                next = null
            };
            int key = value % Size;
            if (chain[key] == null)
            {
                chain[key] = newNode;
            }
            else
            {
                Node temp = chain[key];
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                Node temp = chain[i];
                Console.Write($"chain[{i}] --> ");
                while (temp != null)
                {
                    Console.Write($"{chain[i].data} --> ");
                    temp = temp.next!;
                }
                Console.Write("null\n");

            }
        }
        public int Search(int value){
            int key = value % Size;
            Node temp = chain[key];
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return 1;
                }
                temp = temp.next!;
            }
            return 0;
        }
        public int Delete(int value){
            int key = value % Size;
            Node temp = chain[key];
            if (temp.data == value)
            {
                temp = temp.next!;
                chain[key] = temp;
                return 1;
            }
            else
            {
                while (temp.next != null)
                {
                    if (temp.next.data == value)
                    {
                        temp.next = temp.next.next!;
                        chain[key] = temp.next;
                        return 1;
                    }
                    temp = temp.next!;
                }
                return 0;
            }
        }
    }
}