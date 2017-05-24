using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Media;

namespace Derp
{
	public class IncreaseDifficulty
	{
		private Game1 game;
		public IncreaseDifficulty(Game1 game)
		{
			this.game = game;
		}

		public void increaseDifficulty()
		{
			game.enemySpawnTime = TimeSpan.FromSeconds(0.1);
			MediaPlayer.Stop();
			MediaPlayer.Play(game.trapSong);
		}
			
	}
}
