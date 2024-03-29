﻿namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new Basic.Collections.Stack<int>();
            s.Push(1); // stack contains 1
            s.Push(10); // stack contains 1, 10
            s.Push(100); // stack contains 1, 10, 100
            Console.WriteLine(s.Pop()); // stack contains 1, 10
            Console.WriteLine(s.Pop()); // stack contains 1
            Console.WriteLine(s.Pop()); // stack is empty
        }
    }
}