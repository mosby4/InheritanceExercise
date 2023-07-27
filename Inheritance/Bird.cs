using System;
namespace Inheritance
{
	public class Bird : Animal 
	{
		public Bird()
		{
		}
		public bool isFlightful { get; set; }
		public string beak { get; set; }
		public string size { get; set; }
		public string tweet { get; set; }
	}
}

// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class