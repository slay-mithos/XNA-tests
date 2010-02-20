using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
using WindowsGame2.Controllers;
using WindowsGame2.Models;


namespace WindowsGame2.Views
{
	/// <summary>
	/// This is a game component that implements IUpdateable.
	/// </summary>
	public class GameComponent1 : Microsoft.Xna.Framework.GameComponent, IScene
	{
		private GraphicsDeviceManager graphics;
		private GraphicsDevice device;
		private SpriteBatch spriteBatch;
		private SpriteFont font;
		private Game1 game;

		public GameComponent1(Game game)
			: base(game)
		{
			// TODO: Construct any child components here
			this.game = (Game1)game;
			device = game.GraphicsDevice;
		}

		/// <summary>
		/// Allows the game component to perform any initialization it needs to before starting
		/// to run.  This is where it can query for any required services and load content.
		/// </summary>
		public override void Initialize()
		{
			// TODO: Add your initialization code here
			spriteBatch = new SpriteBatch(device);
			font = Game.Content.Load<SpriteFont>("Arial");
			game.Hero.Pos = new Vector2(50f, 50f);
			base.Initialize();
		}

		/// <summary>
		/// Allows the game component to update itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		public override void Update(GameTime gameTime)
		{
			// TODO: Add your update code here

			base.Update(gameTime);
		}

		public void Draw(GameTime gameTime)
		{
			Actor hero = game.Hero;
			spriteBatch.Begin();
			spriteBatch.DrawString(font, "Welcome", new Vector2(10, 10), Color.AntiqueWhite);
			spriteBatch.Draw(hero.Texture, hero.Pos, hero.GetRectangle(), Color.Chocolate);
			spriteBatch.End();
			
		}
	}
}