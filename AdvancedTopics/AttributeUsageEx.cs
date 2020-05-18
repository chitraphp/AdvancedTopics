using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedTopics
{
	class AttributeUsageEx
	{
	}
    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute
    {

        // Provides name of the member 
        private string name;

        // Provides description of the member 
        private string action;

        // Constructor 
        public MyAttribute(string name, string action)
        {
            this.name = name;
            this.action = action;
        }

        // property to get name 
        public string Name
        {
            get { return name; }
        }

        // property to get description 
        public string Action
        {
            get { return action; }
        }
    }

    class Student
    {

        // Private fields of class Student 
        private int rollNo;
        private string stuName;
        private double marks;

        // The attribute MyAttribute is applied  
        // to methods of class Student 
        // Providing details of their utility 
        [MyAttribute("Modifier", "Assigns the Student Details")]
        public void setDetails(int r,
                                                                          string sn, double m)
        {
            rollNo = r;
            stuName = sn;
            marks = m;
        }

        [MyAttribute("Accessor", "Returns Value of rollNo")]
        public int getRollNo()
        {
            return rollNo;
        }

        [MyAttribute("Accessor", "Returns Value of stuName")]
        public string getStuName()
        {
            return stuName;
        }

        [MyAttribute("Accessor", "Returns Value of marks")]
        public double getMarks()
        {
            return marks;
        }
    }
}
