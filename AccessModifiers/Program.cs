using System;

namespace AccessModifiers
{
    public class Program
    {
        //with in the class there is no restrication
        //when we access outside the class then it will start the access restriction
        //members under 
        // Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected AccessModifiers
        //accessing members of a class with in the class
        private void TestPrivate()
        {
            Console.WriteLine("Private Method");
        }
        internal void TestInternal()
        {
            Console.WriteLine("internal Method");
        }
        protected void TestProtected()
        {
            Console.WriteLine("protected Method");
        }
        protected internal void TestprotectedInternal()
        {
            Console.WriteLine("protected internal Method");
        }
        public void TestPublic()
        {
            Console.WriteLine("public Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestPrivate();
            p.TestInternal();
            p.TestProtected();
            p.TestprotectedInternal();
            p.TestPublic();
            Console.ReadLine();
        }
    }
}
