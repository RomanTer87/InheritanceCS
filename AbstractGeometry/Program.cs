using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace AbstractGeometry
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IntPtr hwnd = GetConsoleWindow();
			System.Drawing.Graphics graphics = Graphics.FromHwnd(hwnd);
			System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
				(
				Console.WindowLeft, Console.WindowTop,
				Console.WindowWidth, Console.WindowHeight
				);
			PaintEventArgs e = new PaintEventArgs(graphics, window_rect);

			Rectangle rect = new Rectangle(150, 150, 250, 150, 5, Color.Green);
			rect.Info(e);

			Triangle triangle = new Triangle(250, 150, 200, 400, 250, 5, Color.Blue);
			triangle.Info(e);

			Circle circle = new Circle(200, 450, 200, 5, Color.Azure);
			circle.Info(e);
		}
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetConsoleWindow();
		[DllImport("kernel32.dll")]
		public static extern IntPtr GetDC(IntPtr hWnd);
	}
}
