using System;
using System.Collections.Generic;
using System.Text;

namespace SolidAssignment
{
	public class Phone : IDevice
	{
		private IComponent[] components = null;
		public Phone(IComponent[] components)
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
