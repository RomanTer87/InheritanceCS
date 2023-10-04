using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Graduate : Student
	{
		public string Diplom { get; set; }
		public Graduate
			(
			string lastName, string firstName, int age,
			string speciality, string group, double rating, double attendance,
			string diplom
			) : base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Diplom = diplom;
			Console.WriteLine($"GConstructor:\t{this.GetHashCode()}");
		}
		public Graduate(Graduate other):base(other)
		{
			this.Diplom= other.Diplom;
			Console.WriteLine($"GCopyCOnstructor:{this.GetHashCode()}");
		}
		~Graduate() 
		{
			Console.WriteLine($"GDestructor:\t{this.GetHashCode()}");
		}
		public override string ToString()
		{
			return base.ToString() + " " + $"{ Diplom}";
		}
		public override void Print()
		{
			base.Print();
			Console.WriteLine("Diplom:" +Diplom);
		}
	}
}
