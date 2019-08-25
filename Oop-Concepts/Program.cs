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
        }
    }
}
