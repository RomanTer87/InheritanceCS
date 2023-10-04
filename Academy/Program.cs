﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Program
	{
		public static readonly string delimiter = "\n-------------------------------------------\n";
		static void Main(string[] args)
		{
			Human human = new Human("Vercetti", "Tomas", 30);
			//Console.WriteLine(human);
			//Console.WriteLine(delimiter);

			Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW20", 90, 99);
			//Console.WriteLine(student);
			//Console.WriteLine(delimiter);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			//	Console.WriteLine(teacher);
			//Console.WriteLine(delimiter);

			Graduate graduate = new Graduate("Hank", "Shcrader", 40, "Criminalist", "OBN", 80, 70, "How to catch Heisenberg");
			//Console.WriteLine(graduate);
			//Console.WriteLine(delimiter);

			Student tommas = new Student(human, "Theft", "Vice", 98, 99);
			//Console.WriteLine(tommas);

			Console.WriteLine(delimiter);
			Human[] group = new Human[] {student, teacher, graduate, tommas,
				new Teacher("Diaz", "Ricardo", 50, "Weapons distr", 25)};
			for(int i=0;i<group.Length;i++)
			{
				//Console.WriteLine(group[i]);
				group[i].Print();
				Console.WriteLine(delimiter);
			}
		}
	}
}
