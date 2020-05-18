using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTopics
{
    class AttributesDemo
    {
        public class MyClass
        {
            [Obsolete("Don't use OldMethod, use NewMethod instead")]

            static void OldMethod()
            {
                Console.WriteLine("It is the old method");
            }
            static void NewMethod()
            {
                Console.WriteLine("It is the new method");
            }
            
        }
    }
}
