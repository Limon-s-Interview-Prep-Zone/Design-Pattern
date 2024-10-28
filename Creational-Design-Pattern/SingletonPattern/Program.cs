using System;
using System.Threading;


namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread process1 = new Thread(() =>
           {
               TestSingleton("FOO");
               TestNaiveSingleton("FOO");
               TestSingletonWithLazyInitialization("FOO");
               
           });
            Thread process2 = new Thread(() =>
            {
                TestNaiveSingleton("BAR"); // again create BAR instance, singleton is not thread safe.
                TestSingleton("BAR"); // will return existing FOO instance
                TestSingletonWithLazyInitialization("BAR"); // will return existing FOO instance
            });

            process1.Start();
            process2.Start();
            process1.Join();
            process2.Join();
        }

        private static void TestNaiveSingleton(string value)
        {
            NaiveSingleton naiveSingleton = NaiveSingleton.GetInstance(value);
            Console.WriteLine($"Naive Singleton: {naiveSingleton.Value}");
        }
        
        private static void TestSingletonWithLazyInitialization(string value)
        {
            LazyInitialization lazyInitialization = LazyInitialization.Instance;
            LazyInitialization.Instance.Value = value;
            Console.WriteLine($"LazyInitialization with Singleton: {lazyInitialization.Value}");
        }

        private static void TestSingleton(string value)
        {
            Singleton singleton = Singleton.GetInstance(value);
            Console.WriteLine($"Thread-safe Singleton: {singleton.Value}");
        }
    }
}

/* Output Should:
Thread-safe Singleton: FOO
Naive Singleton: BAR // FOO
Naive Singleton: BAR // FOO
Thread-safe Singleton: 
LazyInitialization with Singleton: FOO
LazyInitialization with Singleton: FOO
 */