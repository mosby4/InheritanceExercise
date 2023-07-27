using System;
namespace Inheritance
{
	public class Reptile : Animal 
	{
		public Reptile()
		{
		}
		public bool isColdBlooded { get; set; }
		public string skin { get; set; }
		public int lungs { get; set; }
		public string fertilizeEggs { get; set;
		}
	}
}

// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class