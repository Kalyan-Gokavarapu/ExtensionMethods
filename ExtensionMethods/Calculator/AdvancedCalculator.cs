using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
  class AdvancedCalculator : IAdvancedCalculator
  {
    public int _result;
    public int complexCalulation(int a, int b)
    {
      _result = a + b * a * b;
      return _result;
    }

    public int GetResult()
    {
      return _result;
    }

    public void SetResult(int result)
    {
      _result = result;
    }
  }
}
