using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    public class DoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> startNode = null;

        public uint Size
        {
            get
            {
                uint count = 0;
                DoubleLinkedListNode<T> temp = startNode;
                if(temp == null)
                {
                    return count;
                }
                else
                {
                    while(temp != null)
                    {
                        temp = temp.Next;
                        count++;
                    }
                    return count;
                }
            }
        }

        public void AddNode(T value, uint index)
        {
            DoubleLinkedListNode<T> newNode = null;

            if (startNode == null)
            {
                startNode = new DoubleLinkedListNode<T>(null, null, value, index);
            }
            else if(index < startNode.Index)
            {
                newNode = new DoubleLinkedListNode<T>(null, startNode, value, index);
                startNode = newNode;
            }
            else if (startNode.Next == null)
            {
                newNode = new DoubleLinkedListNode<T>(startNode, null, value, index);
                startNode.Next = newNode;
            }
            else
            {
                DoubleLinkedListNode<T> previousNode = startNode;
                DoubleLinkedListNode<T> nextNode = startNode.Next;

                while (nextNode != null && index > previousNode.Index && index > nextNode.Index)
                {
                    previousNode = nextNode;
                    nextNode = nextNode.Next;
                }

                newNode = new DoubleLinkedListNode<T>(previousNode, nextNode, value, index);
                previousNode.Next = newNode;

                if (nextNode != null)
                {
                    nextNode.Previous = newNode;
                }
            }
        }

        public void DeleteNode(uint index)
        {
            if(startNode == null)
            {
                throw new Exception("There are not node in this list.");
            }
            else if(startNode.Index == index && startNode.Next == null)
            {
                startNode = null;
            }
            else if(startNode.Index == index)
            {
                startNode = startNode.Next;
                startNode.Previous = null;
            }
            else
            {
                DoubleLinkedListNode<T> previousNode = startNode;
                DoubleLinkedListNode<T> nextNode = startNode.Next;

                while(nextNode != null)
                {
                    if(nextNode.Index == index)
                    {
                        if(nextNode.Next == null)
                        {
                            previousNode.Next = null;
                            nextNode = null; //delete node
                            return;
                        }
                        else
                        {
                            nextNode.Next.Previous = previousNode;
                            previousNode.Next = nextNode.Next;
                            nextNode = null; //delete node
                            return;
                        }

                    }
                    previousNode = nextNode;
                    nextNode = nextNode.Next;
                }

                throw new Exception("Node not found");
            }
        }

        public T[] GetList()
        {
            DoubleLinkedListNode<T> tempNode = startNode;
            T[] list = new T[Size];

            for(int i = 0; i < Size; i++)
            {
                list[i] = tempNode.Value;
                tempNode = tempNode.Next;
            }

            return list;
        }

        public T Search(uint getIndex)
        {
            DoubleLinkedListNode<T> tempNode = startNode;

            if (tempNode == null)
            {
                throw new Exception("There are not node in this list.");
            }
            else
            {
                while (tempNode != null)
                {
                    if (tempNode.Index == getIndex)
                    {
                        return tempNode.Value;
                    }
                    tempNode = tempNode.Next;
                }
            }

            throw new IndexOutOfRangeException("Node Not Found.");
        }
    }
}
