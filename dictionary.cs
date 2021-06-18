using System;
using System.Collections.Generic;

namespace DictionayNameSpace
{
  static class DictionayClass
  {
    static void Main(string[] args)
    {
      IDictionary<int, string> users = new Dictionary<int, string>();
      users.Add(1001, "aashish");
      users.Add(1002, "guhan");
      users.Add(1003, "danush");
      users.Add(1004, "murli");
      users.Add(1005, "amrutha");
      DictionayClass.printDict(users);
      Console.WriteLine(users[1003]);

      users[1004] = "murli k";
      DictionayClass.printDict(users);
    }
    static void printDict(IDictionary<int, string> dict)
    {
      foreach (KeyValuePair<int, string> kvp in dict)
      {
        Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
      }
    }
  }
}

// mcs -out:executable.exe dictionary.cs && mono executable.exe