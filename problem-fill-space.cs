/*
Find out best possible combination to fill the space using standard blocks

Inputs/arguments:
available space (int)
standard blocks (List) 

Example:
Input
	
available space 1000
	standard blocks 300, 400, 600

output

Best possible combination
{600,400}
{400,300,300}
 
If none of the combination fill the entire space then will consider least space left combination is best possible.
*/

using System;
using System.Collections;
using System.Collections.Generic;

namespace ListExample
{
  static class ListClass
  {
    public static int callCount;
    static void Main(string[] args)
    {
      int available = 1000;
      var blocks = new List<int>{300, 400, 600};

      var newList = new ArrayList();
      ListClass.callCount = 0;
      ListClass.backtrack(newList,0,blocks,available,0);
      // Console.WriteLine("CallCount: "+ ListClass.callCount);
    }
    static void backtrack(ArrayList arr, int sum, List<int> blocks, int available, int pos)
    {
      ++ListClass.callCount;
      if (sum == available)
      {
        foreach (int block in arr)
        {
          Console.Write(block + ", ");
        }
        Console.Write("\n");
        return;
      }
      if (sum > available){
        return;
      }
      if (sum < available)
      {
        for (int i = pos; i < blocks.Count; i++) {
          var newArr = new ArrayList();
          newArr.Add(blocks[i]);
          newArr.AddRange(arr);
          ListClass.backtrack(newArr, sum+blocks[i], blocks, available, i);
        }
      }
    }
  }
}

// mcs -out:executable.exe problem-fill-space.cs && mono executable.exe