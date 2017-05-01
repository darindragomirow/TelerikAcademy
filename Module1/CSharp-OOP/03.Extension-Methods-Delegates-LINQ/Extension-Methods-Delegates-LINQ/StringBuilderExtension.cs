using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods_Delegates_LINQ
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder builder,int index,int length)
        {
            string str = builder.ToString();
            str=str.Substring(index, length);
            StringBuilder result = new StringBuilder(str);
            return result;
        }
    }
}
