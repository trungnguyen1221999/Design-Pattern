
namespace Singleton_Design_Pattern
{
    public sealed class Singleton
    {
        private Singleton() { }
        private static Singleton _instance;

        public static Singleton GetSingleton()
        {
            if (_instance == null) { _instance = new Singleton(); }
            return _instance;
        }

        public void DoSomething()
        {

        }
    }
}
