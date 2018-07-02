using System;
using System.Collections.Generic;
using System.Text;

namespace Treehouse.Common
{
    public static class IntExtensions
    {
        public static bool IsEven(this int value)
        {
            return (value & 1) == 0;
        }
    }
}