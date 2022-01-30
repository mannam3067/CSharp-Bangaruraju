using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class VariablesDemo
    {
        int x;   //Non Static
        static int y=200;  //Static
        const string pi = "A const field requires a value to be provided AccessModifiers"; //A const field requires a value to be provided AccessModifiers; 
        readonly int ProjectNumber;
        public VariablesDemo(int Projetnumber)
        {
            ProjectNumber = Projetnumber;
        }
        static void Main(string[] args)
        {
            y = 100;
            VariablesDemo vd = new VariablesDemo(660373);
            vd.x = 200;
            Console.WriteLine(y);
            // A readonly field cannot be assigned to(except in a constructor or init - only setter of the class in which the field is defined or a variable initializer))
            //vd.ProjectNumber = 65749; 
            Console.ReadLine();
        }
    }
}
