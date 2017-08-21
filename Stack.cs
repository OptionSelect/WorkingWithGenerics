using System;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithGenerics
{
    class Stack <T>
    {
       private IList<T> stack = new List<T>();
       public void Push(T item)
       {
           //add item to the top of the stack
           this.stack.Add(item);
       }

       public T Pop()
       {
           //removes from top of the stack
           //in plain english: remove the last element(top of the stack) and return it
           var item = stack.Last();
           this.stack.Remove(item);
           return item;
       }
    }
}