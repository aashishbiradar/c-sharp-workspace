using System;
using System.Collections.Generic;

namespace ListExample
{
  class ListClass
  {
    static void Main(string[] args)
    {
      var strList = new List<string>();
      strList.Add("a");
      strList.Add("b");
      strList.Add("c");
      strList.Add("d");
      strList.Add("e");
      strList.Remove("a");
      strList.RemoveAt(3);
      string[] strList2 = new string[3]{"x", "y", "z"};
      strList.AddRange(strList2);
      foreach (var chr in strList)
      {
        Console.WriteLine(chr);
      }
      Console.WriteLine(strList.Contains("z"));
      Console.WriteLine(strList.Contains("m"));
    }
  }
}

// mcs -out:executable.exe list.cs && mono executable.exe