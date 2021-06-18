using System;
using System.Collections;

namespace ListExample
{
  class ListClass
  {
    static void Main(string[] args)
    {
      var arr1 = new ArrayList();
      arr1.Add(1);
      arr1.Add(10);
      arr1.Add(20);
      arr1.Add(30);
      arr1.Add(50);
      arr1.Remove(1);
      arr1.Remove(30);
      foreach (int num in arr1)
      {
        Console.WriteLine(num);
      }
    }
  }
}

// mcs -out:executable.exe array-list.cs && mono executable.exe