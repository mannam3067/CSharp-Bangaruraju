using System;

namespace AccessModifiers
{
    //consuming members of a class from non child class same project
    class ClassThree
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestInternal();
            p.TestprotectedInternal();
            p.TestPublic();
            Console.ReadLine();
        }
    }
}
