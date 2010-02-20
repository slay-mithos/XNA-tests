using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using WindowsGame2.Models;

namespace WindowsGame2.Controllers
{
	class KeyboardController
	{
		private KeyboardState keyState;
		private GamePadState padState;
		public Game1 game;

		public KeyboardController(Game1 game)
		{
			this.game = game;
		}

		public void ProcessController()
		{
			keyState = Keyboard.GetState();
			padState = GamePad.GetState(Microsoft.Xna.Framework.PlayerIndex.One);
			Actor hero = (Actor)game.Hero;


			/* 
			 * GamePad inputs
			 */

			//Moving
			if (padState.IsButtonDown(Buttons.LeftThumbstickLeft) || keyState.IsKeyDown(Keys.Left))
			{
				hero.Pos.X -= 1.5f;
				hero.NextPosture(ActorDirection.Left);
			}
			if (padState.IsButtonDown(Buttons.LeftThumbstickRight) || keyState.IsKeyDown(Keys.Right))
			{
				hero.Pos.X += 1.5f;
				hero.NextPosture(ActorDirection.Right);
			}

			//Jump
			if (padState.IsButtonDown(Buttons.LeftThumbstickUp))
			{
				
			}

			if (padState.IsButtonDown(Buttons.LeftThumbstickDown))
			{
				
			}
		}
	}
}
