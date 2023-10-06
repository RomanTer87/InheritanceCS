using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Human
	{

		public string LastName { get; set; }
		public string FirstName { get; set; }
		public int Age { get; set; }
		public Human(string lastName, string firstName, int age)
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstructor:\t{this.GetHashCode()}");
		}
		public Human(Human other)
		{
			this.LastName= other.LastName;
			this.FirstName= other.FirstName;
			this.Age = other.Age;
			Console.WriteLine($"HCopyConstructor:{this.GetHashCode()}");
		}
		~Human()
		{
			Console.WriteLine($"HDestructor:\t{this.GetHashCode()}");
		}
		public override string ToString()
		{
			return $"{LastName}, {FirstName}, {Age}";
		}
		public virtual void Init(string[] values)
		{
			LastName= values[1];
			FirstName= values[2];
			Age = Convert.ToInt32(values[3].Split(' ')[1]);
		}

		public virtual void Print()
		{
			Console.WriteLine(this.GetType());
			Console.WriteLine("Last name:\t"+LastName);
			Console.WriteLine("First name:\t"+FirstName);
			Console.WriteLine("Age:\t\t"+Age);
		}
	}
}
