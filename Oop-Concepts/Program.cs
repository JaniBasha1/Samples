using System;

namespace Oop_Concepts
{
    class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            //Only DoIt is visible to me
            Abstraction abs = new Abstraction();
            abs.DoIt();

            //Inheritance

            Parent p = new Parent();           
            p.ParentMethod_1();

            Child1 ch1 = new Child1();                
            ch1.ParentMethod_1(); //using over-ride //Child1 o/p

            // Child1 ch1_1 = new Parent();
            // ch1_1.ParentMethod_1(); - Error

            Parent ch1_2 = new Child1();             
            ch1_2.ParentMethod_1(); //using over-ride

            Child2 ch2 = new Child2();
            ch2.ParentMethod_1(); //using New //Parent o/p
            
            //important!!
            Parent ch2_1 = new Child2();
            ch2_1.ParentMethod_1();

            //Output
            // ParentMethod
            // ParentMethod_1 in child1
            // ParentMethod_1 in child1
            // ParentMethod_1 in Child2 as new
            // ParentMethod

        }
    }
}
