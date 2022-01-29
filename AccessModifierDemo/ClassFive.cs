using AccessModifiers;
using System;

namespace AccessModifierDemo2
{
    class ClassFive
    {
        private static void Main(string[] args)
        {
            Program p = new Program();
            p.TestPublic();
            Console.ReadKey();
        }
        
    }
}
