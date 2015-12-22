using DataTypes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public class CircularWindow : Window
	{
		public decimal Radius
		{
			get;
			private set;
		}

		public override decimal CalculateArea()
		{
			return (decimal)Math.PI * Radius * Radius;
		}

		// IN real life, don't really want a default ctor
		// 0x0 window makes no physical sense.
		public CircularWindow()
			: this(1M)
		{

		}

		public CircularWindow(decimal radius)
			: base() //Call base constructor
		{
			Radius = radius;
		}

		
	}
}