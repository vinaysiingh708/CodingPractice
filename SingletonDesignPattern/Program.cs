using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object padlock = new object();

        // Private constructor to prevent instantiation from outside
        private Singleton()
        {
        }

        // Public property to provide global access to the instance
        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                    }
                }
                return instance;
            }
        }

        // Example method to demonstrate the Singleton usage
        public void DoSomething()
        {
            Console.WriteLine("Singleton instance method called.");
        }
    }

    class Program
    {
        static void Main()
        {
            Singleton singleton1 = Singleton.Instance;
            Singleton singleton2 = Singleton.Instance;

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Both instances are the same.");
            }

            singleton1.DoSomething();
        }
    }
}
