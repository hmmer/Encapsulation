using System;
using Encap;

class Program 
{
  public static void Main (string[] args) 
  {
      Laptop mac = new Mac();

      //Turnon is Public and it can be accessed outside the class
      mac.TurnOn();
  }
}