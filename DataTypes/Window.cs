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

		//This is a totally bulshit example to show a static member in a class!!!
		//Insane design ahead
		//This will be used to count all open/closes across all instances
		//********************************************************************
		public static int OpenCloseCounter { get; private set; }
		//********************************************************************
		public bool IsOpen { get; private set; }

		protected void ToggleWindowOpeness(bool newState)
		{
			if (IsOpen != newState)
			{
				IsOpen = newState;
				OpenCloseCounter++;
			}
		}

		public virtual void Open()
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
