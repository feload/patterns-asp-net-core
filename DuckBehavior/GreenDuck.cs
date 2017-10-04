using System;
namespace DuckBehavior
{
	public class GreenDuck : Duck
	{
		public GreenDuck()
		{
			this.flyBehavior = new FlyWithWings();
			this.quackBehavior = new QuackHard();
		}
	}
}
