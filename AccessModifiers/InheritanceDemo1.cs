using System;

namespace AccessModifiers
{
    //how many methods are there in inheritence class(InheritanceDemo1) mean 3 methods why my father propert belongs to me (parent class contains only 2 methods + 1 method child class)
    class InheritanceDemo1 :InheritanceDemo
    {
        public InheritanceDemo1(int i):base(i)
        {

        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            InheritanceDemo InheritDemo;// InheritDemo is a variable of class1
            InheritanceDemo1 interDemo = new InheritanceDemo1(10); //interDemo is instance of class2
            InheritDemo= interDemo;// InheritDemo is a reference of parent class created by using child class instance
            interDemo.Test1();  //InterfaceDemo.Test1(); we can drive the car but registration having with my father name internally belongs to parent class
            interDemo.Test2();
            interDemo.Test3();
            InheritDemo.Test1(); //calling using parent class reference

            //we can create the instance for object class with out inherit any class
            Object obj = new Object();
            obj.GetType();
            InheritanceDemo1 Inheritdemo = new InheritanceDemo1(20);
            Console.ReadLine();
        }
    }
}
