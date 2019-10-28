using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    class Stack<T> : SimpleList<T>
        where T : IComparable
    {
        protected SimpleListItem<T> head
        { get; set; }
        public Stack()
        {
            this.head = null;
        }
        public void Push(T element)
        {
            SimpleListItem<T> a = new SimpleListItem<T>(element);
            if (this.head == null)
            {
                this.last = a;
                this.last.next = null;
                this.head = this.last;
                this.Count = 1;
            }
            else
            {
                a.next = this.last;
                this.last = a;
                this.head = this.last;
                ++this.Count;
            }
        }
        public T Pop()
        {

            if (this.Count != 0)
            {
                SimpleListItem<T> a = this.head;
                this.head = this.last.next;
                this.last = this.head;
                --this.Count;
                return a.data;
            }
            else throw new ExcNULL("Попытка считать из пустого стека");
        }
    }
}
