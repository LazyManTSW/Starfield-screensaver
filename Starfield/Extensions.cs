using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Starfield
{    
    internal static class Extensions
    {
        public static bool FindColor<T>(this List<T> list, T target)
        {
            return list.Contains(target);
        }
    }
}
