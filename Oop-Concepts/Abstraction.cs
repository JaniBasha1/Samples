using System;

class Abstraction
{
   //Hiding the Implementation is Abstraction
   //Console.WriteLine - We dont know what is behind it

    private int a = 10, b=20;

    //Only DoIt is visible to other world.
    public void DoIt(){
        Addition();
    }

    void Addition(){
        Console.WriteLine("Abstraction Addition ...." + (a + b));
    }
}