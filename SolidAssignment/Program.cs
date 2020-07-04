using System;

namespace SolidAssignment
{
	
	public class Program
	{
		private static Computer _computer;
		private static Phone _phone;
		private static Tablet _tablet;
		public static void Main()
		{
			Console.WriteLine("Testing Computer...");
			_computer = new Computer(
				new IComponent[]
				{
					new MotherBoard(),
					new Cpu(),
					new Ram(),
					new HardDrive(),
					new PowerSupply()
				}
				);
			_computer.Test();

			Console.WriteLine("\nTesting Phone...");
			_phone = new Phone(
				new IComponent[]
				{
					new MotherBoard(),
					new Cpu(),
					new Ram(),
					new Screen(),
					new Battery()
				}
				);
			_phone.Test();

			Console.WriteLine("\nTesting Tablet...");
			_tablet = new Tablet(
				new IComponent[]
				{
					new MotherBoard(),
					new Cpu(),
					new Ram(),
					new Screen(),
					new Battery()
				}
				);
			_phone.Test();

		}
	}

}