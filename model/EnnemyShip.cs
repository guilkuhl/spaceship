using System;

namespace strange.examples.signals
{
	public class EnnemyShip :IShip
	{
		public int life{get;set;}
		public IWeapon weapon{get;set;}
		public EnnemyShip ()
		{
			this.life = 100;
		}
	}
}

