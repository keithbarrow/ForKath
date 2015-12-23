using DataTypes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public class RectangularWindow : Window
	{
		//Field
		private decimal height;
		
		//Explicity Declared get/ set property
		public decimal Height
		{
			get 
			{ 
				return height; 
			}
			private set 
			{
				//Can add validatio here
				height = value; 
			}
		}

		//Auto property: generates backing field
		public decimal Width
		{
			get;
			private set;
		}

		public override decimal CalculateArea()
		{
			return GeometricShapeAreaCalculator.Rectangle(Width, Height);
		}

		// IN real life, don't really want a default ctor
		// 0x0 window makes no physical sense.
		public RectangularWindow()
			: this(2M, 1M)
		{

		}

		public RectangularWindow(decimal height, decimal width)
			: base()
		{
			Height = height;
			Width = width;
		}


	}
}