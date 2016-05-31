using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electroman
{
    public class Player
    {
        public Vector2 Position;
        private Color vortexColour;
        private int walkFrame, walkFrameTime;

        public Player(Vector2 pos)
        {
            Position = pos;
            vortexColour = Color.Red;
            walkFrame = 0;
            walkFrameTime = 0;
        }

        public void Update(GameTime gameTime, KeyboardState keyboardState)
        {
            vortexColour.R += (byte)(gameTime.ElapsedGameTime.Milliseconds * 0.3);
            vortexColour.G += (byte)(gameTime.ElapsedGameTime.Milliseconds * 0.2);
            vortexColour.B += (byte)(gameTime.ElapsedGameTime.Milliseconds * 0.4);

            walkFrameTime += gameTime.ElapsedGameTime.Milliseconds;
            if (walkFrameTime > 50)
            {
                walkFrame++;
                walkFrameTime = 0;
                if (walkFrame > 3)
                    walkFrame = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.Draw(
                texture: Game1.SpriteLibrary[0],
                position: Position,
                color: Color.White,
                sourceRectangle: new Rectangle(0, Game1.SpriteLibrary[0].Height / 4 * walkFrame, Game1.SpriteLibrary[0].Width, Game1.SpriteLibrary[0].Height / 4),
                origin: new Vector2(Game1.SpriteLibrary[0].Width, Game1.SpriteLibrary[0].Height / 4));
            spriteBatch.Draw(
                texture: Game1.SpriteLibrary[1],
                position: Position,
                color: vortexColour,
                sourceRectangle: new Rectangle(0, Game1.SpriteLibrary[1].Height / 4 * walkFrame, Game1.SpriteLibrary[1].Width, Game1.SpriteLibrary[1].Height / 4),
                origin: new Vector2(Game1.SpriteLibrary[0].Width, Game1.SpriteLibrary[0].Height / 4));

            spriteBatch.End();
        }
    }
}
