using System;
namespace DuckBehavior
{
	public class QuackNoWay : QuackBehavior
	{
		public void Quack()
		{
			Console.WriteLine("<silence>");
		}
	}
}
