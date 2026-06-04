using Singleton_Design_Pattern;

Singleton s1 = Singleton.GetSingleton();
Singleton s2 = Singleton.GetSingleton();

Console.WriteLine(s1);
if (s1 == s2) Console.WriteLine("Singleton works, both variables contain the same instance");
else Console.WriteLine("Singleton fails, variables contain different instance");