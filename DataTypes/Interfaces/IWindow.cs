using System;
namespace DataTypes.Interface
{
	public interface IWindow
	{
		bool IsOpen { get; }		
		void Open();
		void Close();
	}
}
