using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electroman
{
    class Level
    {
        public LevelShape Shape;
        public LevelType Type;
        public Vector2 Position;

        public Level(LevelShape shape, LevelType type)
        {
            Shape = shape;
            Type = type;
            Position = new Vector2(0, 0);
        }

        public void Update(GameTime gameTime)
        {

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            spriteBatch.End();
        }
    }
}
