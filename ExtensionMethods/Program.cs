using System;
using ExtensionMethods.Extensions;
namespace ExtensionMethods
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter your name");
      var str = Console.ReadLine();
      var greetings = str.greetMe();

      Console.WriteLine(greetings);

      SimpleCalculator sc = new SimpleCalculator();
      sc.add(2, 3);
      sc.substract(20, 5);
      sc.multiply(2, 5); // Extension method to Simple Calculator
      sc.printToConsole(); // Extension available to ALL the types that implment IAddOn

      AdvancedCalculator ac = new AdvancedCalculator();
      ac.complexCalulation(2, 3);
      ac.divide(5, 100); //Extention method available to ALL the types that implment IAdvancedCalculator
      ac.printToConsole(); // Extension available to ALL the types that implment IAddOn

      Console.Read();
      


    }
  }
}
