using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_123
{
    class OuterClass
    {
        const int MAX_COUNT = 6;
        class InnerClass
        {
           public void ShowVariableAsString(bool variable)
            {
                string variableAsString =variable.ToString();
                Console.WriteLine(variableAsString);
            }
        }
        public static void EntryMethod()
        {
            OuterClass.InnerClass instance =
              new OuterClass.InnerClass();
            instance.ShowVariableAsString(true);
        }
    }
}
