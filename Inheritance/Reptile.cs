using System;
namespace Inheritance
{
	public class Reptile : Animal 
	{
		public Reptile()
		{
		}
		public bool IsColdBlooded { get; set; }
		public string Skin { get; set; }
		public int Lungs { get; set; }
		public string FertilizeEggs { get; set;
		}
	}
}

// give this class 4 members that are specific to Reptile
// Set this class to inherit from your Animal Class