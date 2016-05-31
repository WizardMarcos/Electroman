using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Electroman
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        public static Random MainRandom;
        public static Texture2D[] SpriteLibrary;
        public static Player ThePlayer;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            MainRandom = new Random();
            SpriteLibrary = new Texture2D[2];
            ThePlayer = new Player(new Vector2(400, 200));

            string windowName;
            switch (MainRandom.Next(1, 6))
            {
                case 1:
                    windowName = ": Clever phrase 1";
                    break;
                case 2:
                    windowName = ": Witty phrase 2";
                    break;
                case 3:
                    windowName = " 2: Electric Boogaloo";
                    break;
                case 4:
                    windowName = ": Washing Machine Man";
                    break;
                case 5:
                    windowName = " Episode I: The Magnetic Menace";
                    break;
                default:
                    windowName = "";
                    break;
            }
            this.Window.Title = "Electroman" + windowName;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            for (int i = 0; i < SpriteLibrary.Length; i++)
                SpriteLibrary[i] = Content.Load<Texture2D>("Images/" + i);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            KeyboardState keyboardState = Keyboard.GetState();

            ThePlayer.Update(gameTime, keyboardState);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            ThePlayer.Draw(spriteBatch);

            base.Draw(gameTime);
        }
    }
}
