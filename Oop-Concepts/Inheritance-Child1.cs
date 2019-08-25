using System;
class Child1 : Parent
{
    public Child1(){
        //Console.WriteLine("Child 1 Constructure");
    }

    public void Multiple(){
        Console.WriteLine("Child1 Multiple ...."+ a*b);
    }

    // public override void ParentMethod(){
    //     Console.WriteLine("ParentMethod in child1");
    // }

    public override void ParentMethod_1(){
        Console.WriteLine("ParentMethod_1 in child1");
    }
}