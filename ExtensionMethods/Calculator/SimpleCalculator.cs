using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
  class SimpleCalculator: IAddOn
  {
    public int _result;
    public int add (int a, int b)
    {
      _result = a + b;
      return _result;
    }

    public int substract(int a, int b)
    {
      _result = a - b;
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
