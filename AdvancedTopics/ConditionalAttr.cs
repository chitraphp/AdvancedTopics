//#define TRACE_ON
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;


namespace AdvancedTopics
{
	class ConditionalAttr
	{
        [Conditional("TRACE_ON")]
        public static void Msg(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    [Conditional("DEBUG")]
    public class DocumentationAttribute : System.Attribute
    {
        string text;
        public DocumentationAttribute(string text)
        {
            this.text = text;
        }
    }

    public class SampleClass
    {
        // This attribute will only be included if DEBUG is defined.
        [Documentation("This method displays an integer.")]
        public static void DoWork(int i)
        {
            System.Console.WriteLine(i.ToString());
        }
    }
}
