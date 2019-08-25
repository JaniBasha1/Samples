using System;
class Child2:Parent
{
    public Child2(){
        //Console.WriteLine("Child2 Constructor...");
    }

     public new void ParentMethod_1(){
        Console.WriteLine("ParentMethod_1 in Child2 as new");
    }
}