using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Security.Policy;

namespace AbstractGeometry
{
	internal class Triangle : Shape
	{
		double side_one;
		double side_two;
		double side_three;
		public double SideOne
		{
			get { return side_one; }
			set
			{
				if (side_one < MIN_SIZE) side_one = MIN_SIZE;
				if (side_one > MAX_SIZE) side_one = MAX_SIZE;
				side_one = value;
			}
		}
		public double SideTwo
		{
			get { return side_two; }
			set
			{
				if (side_two < MIN_SIZE) side_two = MIN_SIZE;
				if (side_two > MAX_SIZE) side_two = MAX_SIZE;
				side_one = value;
			}
		}
		public double SideThree
		{
			get { return side_three; }
			set
			{
				if (side_three < MIN_SIZE) side_three = MIN_SIZE;
				if (side_three > MAX_SIZE) side_three = MAX_SIZE;
				side_three = value;
			}
		}
		public Triangle(double side_one, double side_two, double side_three, int start_x, int start_y, int line_width, Color color)
			: base(start_x, start_y, line_width, color)
		{
			SideOne = side_one;
			SideTwo = side_two;
			SideThree = side_three;
		}
		public override double GetArea()
		{
			double pperimetr = this.GetPerimeter() / 2;
			return Math.Round(Math.Sqrt(pperimetr * (pperimetr - side_one) * (pperimetr - side_two) * (pperimetr - side_three)));
		}
		public override double GetPerimeter()
		{
			return side_one + side_two + side_three;
		}
		public double Heigth()
		{
			return (2 * GetPerimeter() / SideOne);
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
			Console.WriteLine($"Длина стороны A: {SideOne}");
			Console.WriteLine($"Длина стороны B: {SideTwo}");
			Console.WriteLine($"Длина стороны C: {SideThree}");
			Console.WriteLine($"Высота: {Heigth()}");
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			Point[] point = new Point[]
				{
					new Point(StartX, StartY),
					new Point(StartX, StartY+(int)SideOne),
					new Point(StartX+(int)SideOne, StartX)
				};
			e.Graphics.DrawPolygon(pen, point);
		}
	}
}
