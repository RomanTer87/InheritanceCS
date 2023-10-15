using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Circle : Shape
	{
		double radius;
		public double Radius
		{
			get { return radius; }
			set
			{
				if (value < MIN_RADIUS) value = MIN_RADIUS;
				if (value > MAX_RADIUS) value = MAX_RADIUS;
				radius = value;
			}
		}
		public Circle
			(
			double radius,
			int start_x, int start_y, int line_width, Color color
			) : base(start_x, start_y, line_width, color)
		{
			Radius = radius;
		}
		public override double GetArea()
		{
			return Math.PI * (radius * radius);
		}
		public override double GetPerimeter()
		{
			return 2 * (Math.PI * radius);
		}
		public override void Info(PaintEventArgs e)
		{
			base.Info(e);
			Console.WriteLine($"Радиус: {radius}");
		}
		public override void Draw(PaintEventArgs e)
		{
			Pen pen = new Pen(Color, LineWidth);
			e.Graphics.DrawEllipse(pen, StartX, StartY, (float)radius, (float)radius);
		}
	}
}
