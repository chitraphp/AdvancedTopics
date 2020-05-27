using System;
using System.Runtime.CompilerServices;

namespace IndexersDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Student student = new Student(12, "chitra");
			student["name"] = "suchi";
			Console.WriteLine("student[name]"+student["name"]);
			Console.WriteLine("student[1] " + student[1]);
			Console.ReadLine();

		}
	}

	public class Student
	{
		public int ID { get; set; }
		public string Name { get; set; }

		public Student(int i, string str)
		{
			ID = i;
			Name = str;
		}

		public Object this[int i]
		{
			get
			{
				if (i == 0)
					return ID;
				else if (i == 1)
					return Name;
				else
					return null;
			}
			set
			{
				if (i == 0)
					ID = Convert.ToInt32(value);
				else if (i == 1)
					Name = value.ToString();
			}
		}

		public Object this[string str]
		{
			get
			{
				if (str.ToLower() == "ID".ToLower())
					return ID;
				else if (str.ToLower() == "Name".ToLower())
					return Name;
				else return null;
			}
			set
			{
				if (str.ToLower() == "ID".ToLower())
					ID = Convert.ToInt32(value);
				else if (str.ToLower() == "Name".ToLower())
					Name = value.ToString();				
			}
		}
	}
}
