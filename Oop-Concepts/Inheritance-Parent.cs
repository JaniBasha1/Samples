using System;
class Parent 
{
    protected int a = 10, b=20;
    //private constructors
    //make inaccessible
    // Parent()
    // {
    //     Console.WriteLine("Parent constructor");
    // }

    public Parent()
    {
        //Console.WriteLine("Parent constructor");
    }

    protected void Add(){
        Console.WriteLine("Parent Add .... "+ (a+b));
    }

    // public abstract void ParentMethod(){
    //     Console.WriteLine("ParentMethod");
    // }
    
     public virtual void ParentMethod_1(){
        Console.WriteLine("ParentMethod");
    }
}