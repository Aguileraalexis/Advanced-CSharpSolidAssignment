using System;
using System.Collections.Generic;
using System.Text;

namespace SolidAssignment
{
	public class Computer : IDevice
	{
		private IComponent[] components = null;
		public Computer(IComponent[] components)
		{
			this.components = components;
		}

		public void Test()
		{

			foreach (var component in components)
			{
				component.Test();
			}

		}
	}

}
