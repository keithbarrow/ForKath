using DataTypes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			//EnumTester.Test(
			var rectangularWindow = new RectangularWindow(2M, 5M);
			
			AreaTester(rectangularWindow);
			WindowOpenTester(rectangularWindow);
			var circularWindow = new CircularWindow(1);
			AreaTester(circularWindow);
			WindowOpenTester(circularWindow);
			Console.ReadKey();
		}

		static void AreaTester(ICalculateArea window)
		{
			Console.WriteLine(window.CalculateArea());
		}

		static void WindowOpenTester(IWindow window)
		{
			Console.WriteLine(window.IsOpen);
			window.Open();
			Console.WriteLine(window.IsOpen);
		}
	}
}
