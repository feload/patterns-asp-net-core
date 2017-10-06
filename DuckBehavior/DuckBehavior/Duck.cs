using System;
namespace DuckBehavior
{
	public abstract class Duck
	{
		public FlyBehavior flyBehavior;
		public QuackBehavior quackBehavior;

		public void setFlyBehavior(FlyBehavior flyBehavior){
			this.flyBehavior = flyBehavior;
		}

		public void setQuackBehavior(QuackBehavior quackBehavior) {
			this.quackBehavior = quackBehavior;
		}

		public void performFly() {
			flyBehavior.Fly();
		}

		public void performQuack () {
			quackBehavior.Quack();
		}
	}
}
