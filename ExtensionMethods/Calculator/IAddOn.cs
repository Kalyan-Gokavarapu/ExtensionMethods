using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
  public interface IAddOn
  {
    int GetResult();
    void SetResult(int result);
  }
}
