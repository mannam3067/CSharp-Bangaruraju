using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //Implementing method hiding concept
    class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Parent class Test()1 method");
        }
        public void Test2()
        {
            Console.WriteLine("Parent class Test()2 method");
        }
        public void Test3()
        {
            Console.WriteLine("Parent class Test()3 method");
        }
    }
    class ChildClass:ParentClass
    {
        public override void Test1() //method override
        {
            Console.WriteLine("this Test1() Child Class implemented method overriding from parent class");
        }
         //here i didn't Use the new keyword, we can implement method but compliler showing warning if hiding was intended.AccessModifiers
        public void Test2()
        {
            Console.WriteLine("this Test2() Child Class implemented method  with out using new Keyword from parent class");
        }
        //intentionally defined a method called it which is defined already in the parent class again we have done it 
        public new void Test3() //Method hiding
        {
            Console.WriteLine("this Test3() Child Class implemented method using new Keyword from parent class");
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main(string[] args)
        {
            //after re-implementing parent class method's in child class and creating an instance using child class
            //we can access only child class implemented methods only we cont access parent class methods
            //point 2:-
            // If we remove the child class implemented methods then it will read and displaying parent class methods
            //point 3:- the first preference always goes to the clocal only
            //by creating the instance of parent class under child class we can call parent's method from child method
            //by using the base keyword also we can call parent's method from child class, but keywords like THIS and BASE can't be used from static block
            ParentClass p = new ParentClass();
            p.Test1();
            p.Test2();
            p.Test3();
           //keywords like THIS and BASE can't be used from static block
            //base.Test1();
            //base.Test2();
            //base.Test3();
            ChildClass c = new ChildClass();
            c.Test1();
            c.Test2();
            c.Test3();
            //like this there is a chance to recall the parent class methods after reimplenting parent class methods in child class
            c.ParentTest1();
            c.ParentTest2();

            //what is the difference b/w overriding and hiding? 
            ChildClass c1 = new ChildClass(); //c1 is instance of child class
            ParentClass p1 = c1; //p is a reference of parent class created by using child's class
            //both P1 and C1 will bw pointing to the same momory location C1(instance) and P1(reference) 
            //using P1 can call any members that are defined in the child class
            p1.Test1();//Invoke child classes method (Here we are getting permission using virtual and overriding keywords so parent class reference calling child class implementation)
            p1.Test2();//Invoke the parent class method(Here we are not getting any permissions so parent class reference caling parent class implemented methods
            p1.Test3();
            Console.ReadLine();
        }
    }
}
