using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace WindowsGame2.Models
{
	public class Actor
	{

		public int HitPoints;
		public Vector2 Pos;
		public Texture2D Texture;
		public ActorDirection Direction;
		public float PostureNumber;
		public float Speed;
		

		public Actor()
		{
			Direction = 0;
			PostureNumber = 0;
		}

		public Rectangle? GetRectangle()
		{
			return new Rectangle(((int)PostureNumber) * 45, ((int)Direction) * 49, 45, 49);
		}

		public void NextPosture(ActorDirection direction)
		{
			if (direction == this.Direction)
				PostureNumber = (PostureNumber + 0.1f) % 4;
			else
			{
				PostureNumber = 0;
				this.Direction = direction;
			}

		}
	}

	public enum ActorDirection
	{
		Right = 2,
		Left = 1,
		Jump = 0,
		Crouch = 3
	}

}
