using System;

namespace SolidAssignment
{
	internal class PowerSupply : IComponent
	{
		public string ProducePower()
		{
			return "Producing Power";
		}

        public void Test()
        {
			Console.WriteLine(ProducePower());
        }

    }

	internal class HardDrive : IComponent
	{
		public string WritingData()
		{
			return "Writing Data";
		}

		public void Test()
		{
			Console.WriteLine(WritingData());
		}

	}

	internal class Ram : IComponent
	{
		public string StoringData()
		{
			return "Storing Data";
		}

		public void Test()
		{
			Console.WriteLine(StoringData());
		}

	}

	internal class Cpu : IComponent
	{
		public string Calculate()
		{
			return "Calculating";
		}

		public void Test()
		{
			Console.WriteLine(Calculate());
		}

	}

	internal class MotherBoard : IComponent
	{
		public string Motherboarding()
		{
			return "Connecting everything";
		}

		public void Test()
		{
			Console.WriteLine(Motherboarding());
		}

	}

	internal class Screen : IComponent
	{
		public string ShowingScreen()
		{
			return "Showing Apps";
		}

		public void Test()
		{
			Console.WriteLine(ShowingScreen());
		}

	}

	internal class Battery : IComponent
	{
		public string SupplyingPower()
		{
			return "Supplying Power";
		}

		public void Test()
		{
			Console.WriteLine(SupplyingPower());
		}

	}

}