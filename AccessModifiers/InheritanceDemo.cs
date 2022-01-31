using System;
namespace AccessModifiers
{
    class InheritanceDemo
    {
        public InheritanceDemo(int i)
        {
            Console.WriteLine("Parent class constructor"+i);
        }
        public void Test1()
        {
            Console.WriteLine("Method 1");
        }
        public void Test2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
