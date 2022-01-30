using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    //how many methods are there in inheritence class mean 3 methods why my father propert belongs to me (parent class contains only 2 methods + 1 method child class)
    class InheritanceDemo1 :InheritanceDemo
    {
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            InheritanceDemo1 interDemo = new InheritanceDemo1();
            interDemo.Test1();  //InterfaceDemo.Test1(); car registration having with my father name
            interDemo.Test2();
            interDemo.Test3();
        }
    }
}
