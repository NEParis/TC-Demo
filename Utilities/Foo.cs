using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TC.Demo.Utilities
{
    internal class Foo
    {
        internal bool ValidateChoice(string choice)
        {
            if (choice.Length > 10)
                return true;
            else
                return false;
        }
    }
}
