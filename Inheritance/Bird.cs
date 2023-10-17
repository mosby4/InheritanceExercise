using System;
namespace Inheritance
{
	public class Bird : Animal 
	{
		public Bird()
		{
		}
		public bool IsFlightful { get; set; }
		public string Beak { get; set; }
		public string Size { get; set; }
		public string Tweet { get; set; }
	}
}

// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class