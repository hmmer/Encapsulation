using System;

namespace Encap
{
    public class Mac : Laptop
    {
        public override void TurnOn()
        {
            // protected class in Laptop can be accessed in inhertied class
            base.PowerOn();

            // private methods can only be accessed within
            this.BIOSROM();
            this.BootLoader();
            
            Console.WriteLine("Turning On Macbook");
        }

        //BIOSROM, PRIVATE can only be used within the class, here it is Mac class
        private void BIOSROM()
        {
            Console.WriteLine("BIOS ROM is in process...");
        }

        private void BootLoader()
        {
            Console.WriteLine("Bootloader is happening...");
        }
    }
}