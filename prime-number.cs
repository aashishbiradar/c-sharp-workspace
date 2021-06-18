using System;

namespace Prime
{
  class PrimeNumbers
  {
    static void Main(string[] args) 
    {
      Console.WriteLine("Enter a number");
      int num = Convert.ToInt32(Console.ReadLine());
      bool isPrime = true;
      for (int i = 2; i < num; i++)
      {
        if (num % i == 0)
        {
          isPrime = false;
          break;
        }
      }
      if (isPrime)
      {
        Console.WriteLine("{0} is a prime number", num);
      }
      else
      {
        Console.WriteLine("{0} is not a prime number", num);
      }
    }
  }
}