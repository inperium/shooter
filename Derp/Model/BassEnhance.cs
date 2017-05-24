using System;

namespace Derp
{

	public class BassEnhance
	{
		private Game1 game;
		public BassEnhance(Game1 game)
		{
			this.game = game;
		}

		public void DoBassEnhance()
		{
			for (int i = 0; i < 100; i++)
			{
				game.AddEnemy();
			}
				
		}

	}
}
