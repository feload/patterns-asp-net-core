using System;

namespace DuckBehavior
{
	class Program
	{
		static void Main(string[] args)
		{
			Duck greenDuck = new GreenDuck();
			greenDuck.performQuack();
			greenDuck.setQuackBehavior(new QuackNoWay());
			greenDuck.performQuack();
			greenDuck.performFly();
			greenDuck.setFlyBehavior(new FlyWithRockets());
			greenDuck.performFly();
		}
	}
}
