using DataTypes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
	public abstract class Window : IWindow, ICalculateArea
	{
		public bool IsOpen { get; private set; }

		private void ToggleWindowOpeness(bool newState)
		{
			if (IsOpen != newState)
			{
				IsOpen = newState;
			}
		}

		public void Open()
		{
			ToggleWindowOpeness(true);
		}

		public void Close()
		{
			ToggleWindowOpeness(false);
		}


		public abstract decimal CalculateArea();

		public Window()
		{
			IsOpen = false;
		}
	}
}
