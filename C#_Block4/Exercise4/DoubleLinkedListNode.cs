using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode<T> Previous { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }
        public T Value { get; }
        public uint Index { get; }

        public DoubleLinkedListNode(DoubleLinkedListNode<T> previous, DoubleLinkedListNode<T> next, T value, uint index)
        {
            this.Previous = previous;
            this.Next = next;
            this.Value = value;
            this.Index = index;
        }
    }
}
