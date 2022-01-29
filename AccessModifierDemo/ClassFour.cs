using AccessModifiers;
using System;
namespace AccessModifierDemo1
{
    //consuming member of a class from child class of different project
    class classFour :Program
    {
        static void Main(string[] args)
        {
            classFour cf = new classFour();
            //internal only with in the project but not access out side the project
            cf.TestProtected();
            cf.TestprotectedInternal();
            cf.TestPublic();
        }
    }
}
