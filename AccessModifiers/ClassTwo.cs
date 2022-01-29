using System;

namespace AccessModifiers
{
    //consuming member of a class from child class of same project
    class ClassTwo : Program
    {
        static void Main(string[] args)
        {
            ClassTwo ct = new ClassTwo();
            ct.TestProtected();//can be accessed only child class
            ct.TestprotectedInternal();
            ct.TestInternal();
            ct.TestPublic();
            Console.ReadLine();
        }
    }
}
