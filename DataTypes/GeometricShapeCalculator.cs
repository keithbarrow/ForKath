using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public static class GeometricShapeAreaCalculator
	{
		public static decimal Circle(decimal radius)
		{
			return (decimal)Math.PI * radius * radius;
		}

		public static decimal Rectangle(decimal height, decimal width)
		{
			return width * height;
		}

		static GeometricShapeAreaCalculator()
		{
			//static ctors are still possible - they are called the first 
			//time the static object is accessed.
		}
	}
}
