using System;
using System.Linq;
using System.Collections.Generic;

namespace WorkingWithGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
           var stackInts = new Stack<int>();
           stackInts.Push(1);
           stackInts.Push(2);
           stackInts.Push(3);
           Console.WriteLine(stackInts.Pop());
           Console.WriteLine(stackInts.Pop());
           Console.WriteLine(stackInts.Pop());
           
           var stackStrings = new Stack<string>();
           stackStrings.Push("First");
           stackStrings.Push("Second");
           stackStrings.Push("Third");
           Console.WriteLine(stackStrings.Pop());
           Console.WriteLine(stackStrings.Pop());
           Console.WriteLine(stackStrings.Pop());
        }
    }
}
