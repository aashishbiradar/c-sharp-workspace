using System;

namespace UserInput
{
  class AgePrint
  {
      static void Main(string[] args)
      {
        Console.WriteLine("Enter your Age");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your age is: " + age);
      }
  }
}