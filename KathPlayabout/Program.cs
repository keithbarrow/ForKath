	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using System.Web.UI.DataVisualization.Charting;

	namespace KathPlayabout
	{
		class Program
		{
			static void Main(string[] args)
			{
				Standard("hi");
				Standard(2);
				ParamsArrayMethod("We", "Wish", "You");
				ParamsArrayMethod2("A", "Merry", "Christmas");

				OverloadedMethod(21);
				OverloadedMethod(21, false);
				OverloadedMethod(21, true);

				OpionalArgumentVersion(21);
				OpionalArgumentVersion(21, false);
				OpionalArgumentVersion(21, true);

				Point3D myPoint1 = PointFactory(0f, 0f, 1.4f);
				Point3D myPoint2 = PointFactory(1f, 1f);
				Point3D myPoint3 = PointFactory(1f);
				Point3D myPoint4 = PointFactory(0F,0F,1f); //Without Named Parameter - parameter counting;
				Point3D myPoint5 = PointFactory(z:1f); //name argument - much better!

				Console.WriteLine("Done");
				Console.ReadKey();
			}

			static void Standard(string text)
			{
				//Expects set number or parameters
				Console.WriteLine(text); 
			}
			static void Standard(int number)
			{
				//Overloaded Method - Parameter types differ.
				Console.WriteLine(number);
			}

			static void ParamsArrayMethod(params string[] args)
			{
				//This will take any number of arguments (must be strings)
				Array.ForEach(args, x => Console.WriteLine(x));
			}

			static void ParamsArrayMethod2(string text, params string[] args)
			{
				//Must supply a string, followed by any number of sting args
				Console.WriteLine(text); 
				Array.ForEach(args, x => Console.WriteLine(x));
			}

			static void OverloadedMethod(int number)
			{
				Console.WriteLine(number);
			}

			static void OverloadedMethod(int number, bool doubleIt)
			{
				if (doubleIt) number *= 2;
				OverloadedMethod(number);
			}

			static void OpionalArgumentVersion(int number, bool doubleIt=false)
			{
				if (doubleIt) number *= 2;
				Console.WriteLine(number);
			}

			static Point3D PointFactory(float x=0f, float y =0f, float z =0f)
			{
				return new Point3D(x, y, z);
			}

		}
	}
