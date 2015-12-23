using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public class FrenchWindow : RectangularWindow
	{
		public bool IsLocked { get; private set; }

		public void Unlock()
		{
			IsLocked = false;
		}

		public void Lock()
		{
			IsLocked = true;
		}

		public override void Open()
		{
			if (IsLocked)
			{
				Console.WriteLine("You muppet this is locked!");
			}
			else
			{
				// base.Open(); //This might be better than the following line...
				ToggleWindowOpeness(true);
			}
		}

		public FrenchWindow()
			: this(1.8M, 1M)
		{
		}

		public FrenchWindow(decimal height, decimal width)
			: base(height, width)
		{
			IsLocked = true;
		}
	}
}
