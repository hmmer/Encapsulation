using System;

namespace Encap
{
    public abstract class Laptop
    {
        // TurnOn, PUBLIC can be accessed outside the external class, here it is program class in main.cs
        public abstract void TurnOn();

        // PowerOn, PROTECTED can be accessed by the within the class (Laptop) and in inhertiated class, here it is Mac class
        protected void PowerOn()
        {
            Console.WriteLine("Checking processor...");
            Console.WriteLine("Checking system memory...");
            Console.WriteLine("Checking network...");
        }
    }
}