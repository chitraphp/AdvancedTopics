#define TRACE_ON
#define DEBUG
using System;
using System.Reflection;

namespace AdvancedTopics
{
	class Program
	{
		static void Main(string[] args)
		{
			ConditionalAttr.Msg("Now in Main...");
			Console.WriteLine("Done.");
			SampleClass.DoWork(62);

			//AttributeUsage
			Student s = new Student();
			s.setDetails(1, "Taylor", 92.5);

			Console.WriteLine("Student Details");
			Console.WriteLine("Roll Number : " + s.getRollNo());
			Console.WriteLine("Name : " + s.getStuName());
			Console.WriteLine("Marks : " + s.getMarks());
			//Object[] attrs = s.GetType().GetCustomAttributes(true);
			//foreach(Attribute attr in attrs)
			//{
			//	Console.WriteLine(attr);
			//}
			MemberInfo[] memInfo = typeof(Student).GetMembers();
			foreach(MemberInfo info in memInfo)
			{
				Object[] attrs = info.GetCustomAttributes(true);
				foreach(Attribute attr in attrs)
				{
					Console.WriteLine(attr);
				}
			}
			Console.ReadLine();
		}
	}
}
