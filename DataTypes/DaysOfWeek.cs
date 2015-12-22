using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public enum DaysOfWeek
	{
		//Optionally Specifying value to enumarate to.
		Monday=3,
		Tuesday=4,
		Wednesday=5,
		Thursday=6,
		Friday =0
	}

	//Normally want one per file.
	public static class EnumTester
	{
		public static void Test()
		{
			Console.WriteLine(DaysOfWeek.Monday);
			Console.WriteLine((int)DaysOfWeek.Monday); // Cast to interger
			Console.WriteLine((DaysOfWeek)5); // Casting back to enum type.

			
		}
	}
}
