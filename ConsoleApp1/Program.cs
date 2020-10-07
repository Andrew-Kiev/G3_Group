using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{

			Student student1 = new Student() { Name = "Bill", Age = 25 };

			Student student2 = new Student();
			student2.Name = "Sindy";
			student2.Age = 20;

			Student[] students = new Student[] { student1, student2 };

			Array.Sort(students);

			Console.ReadKey();
		}
	}
}
