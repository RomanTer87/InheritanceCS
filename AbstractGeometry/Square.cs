﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractGeometry
{
	internal class Square:Rectangle
	{
		public Square(int side, int start_x, int start_y, int line_width, Color color)
			: base(side, side, start_x, start_y, line_width, color) { }
	}
}
