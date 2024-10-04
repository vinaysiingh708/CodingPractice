﻿using System;


namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Base obj = new Derive();
            obj.F1();
            obj.F2();
            obj.F3();
            Console.WriteLine("Hello World!");
            // Output : Base F1
            //          Derive F2
            //          Base F3
            //          Hello World!

            Console.ReadLine();
        }
    }
    public class Base
    {
        public void F1() { Console.WriteLine("Base F1"); }
        public virtual void F2() { Console.WriteLine("Base F2"); }
        public virtual void F3() { Console.WriteLine("Base F3"); }
    }
    public class Derive : Base
    {
        new public void F1()
        {
            Console.WriteLine("Derive F1");
        }
        public override void F2()
        {
            Console.WriteLine("Derive F2");
        }
        public new void F3()
        {
            Console.WriteLine("Derive F3");
        }
    }
}



/*
namespace Test
{
    public class MyClass
    {
        public int val;
    }
    public class Program
    {
        private static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            objectA.val = 10;

            MyClass objectB = new MyClass();
            objectB = objectA;
            objectB.val = 50;

            Console.WriteLine("objectA.val = {0}", objectA.val);
            Console.WriteLine("objectB.val = {0}", objectB.val);
            Console.ReadLine();

            // Output : objectA.val = 50
            //          objectB.val = 50

        }
    }
}
*/

