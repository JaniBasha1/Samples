using System;

class Encapsulation
{
   //Hiding the Implementation is Abstraction
   //Console.WriteLine - We dont know what is behind it

    // public are accessed outside of world
    //public int a = 10, b=20;

    //Encapulation within same class
    private int a = 10, b=20;

    //Encapsulation make availability to child classes
    //protected int a = 10, b=20;

    //Only DoIt is visible to other world.
    public void DoIt(){
        Addition();
    }

    void Addition(){
        Console.WriteLine("Abstraction Addition ...." + (a + b));
    }
}