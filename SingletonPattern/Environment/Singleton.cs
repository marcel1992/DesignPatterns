using System;

namespace SingletonPattern.Environment
{
    public sealed class Singleton
    {
        #region Using static initialization

        private static readonly Singleton Instance = new Singleton();
        public static int TotalInstances;

        // Private constructor is used to prevent creation of instances with 'new' keyword outside this class

        private Singleton()
        {
            TotalInstances++;
            Console.WriteLine("--Private constructor is called.");
            Console.WriteLine($"Total instances of singleton: {TotalInstances}");
            Console.WriteLine("--Exit now from private constructor.");
        }

        public static Singleton GetInstance => Instance;

        #endregion
    }
}
