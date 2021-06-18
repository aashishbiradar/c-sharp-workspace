using System;

namespace ArrayIntro
{
  class PrintArray
  {
    static void Main(string[] args)
    {
      string[] cars = {"Ford", "VW", "Skoda", "BMW"};
      foreach(string car in cars)
      {
        Console.WriteLine(car);
      }
    }
  }
}