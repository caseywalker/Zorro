using System;

namespace Zorro
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("The Mask of Zorro!");
      Console.WriteLine("Please enter your secret phrase");
      var userInp = Console.ReadLine();
      while (userInp.Length < 7)
      {
        Console.WriteLine("Please enter a phrase with 7 or more characters");
        userInp = Console.ReadLine();
      }

      var toMask = userInp.Substring(0, userInp.Length - 4);

      var maskLine = "";

      foreach (var x in toMask)
      {
        maskLine += "*";
      }

      var nonMask = userInp.Substring(userInp.Length - 4, 4);

      Console.WriteLine(maskLine + nonMask);

    }
  }
}
