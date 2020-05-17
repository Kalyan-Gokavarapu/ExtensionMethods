using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods.Extensions
{
  static class MyExtension
  {
    public static string greetMe(this string str)
    {
      return ($"Hello {str}!");
    }

    public static int multiply (this SimpleCalculator sc, int a, int b)
    {
      var result = a * b;
      sc.SetResult(result);
      return result;
    }

    public static double divide(this IAdvancedCalculator sc, int a, int b)
    {
      int result = b / a;
      sc.SetResult(result);
      return result;
    }

    public static void printToConsole(this IAddOn obj)
    {
      Console.WriteLine(obj.GetResult());
    }
  }
}
