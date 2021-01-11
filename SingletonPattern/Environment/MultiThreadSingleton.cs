namespace SingletonPattern.Environment
{
    public sealed class MultiThreadSingleton
    {
        //We are using volatile to ensure that assignment to the instance variable finishes before it's access
        private static volatile MultiThreadSingleton Instance;
        private static object lockObject = new object();
        private MultiThreadSingleton() { }

        public static MultiThreadSingleton GetInstance
        {
            get
            {
                //locking it first
                lock (lockObject)
                {
                    //single check
                    if (Instance == null)
                        Instance = new MultiThreadSingleton();
                }

                return Instance;
            }
        }
    }
}
