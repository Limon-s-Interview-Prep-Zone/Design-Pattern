using System;

namespace SingletonPattern
{
    public class LazyInitialization
    {
        // The Singleton's constructor should always be private to prevent
        // direct construction calls with the `new` operator.
        private LazyInitialization() { }
        
        private static readonly Lazy<LazyInitialization> _instance = new Lazy<LazyInitialization>(() => new LazyInitialization());
        
        public static LazyInitialization Instance => _instance.Value;

        public string Value { get; set; }

        public void BusinessLogic()
        {
            // ...
        }
    }
}