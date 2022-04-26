using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace monogame_2
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D rectTexture;
        Texture2D circTexture;
        Rectangle trunk;
        Rectangle[] leaves = new Rectangle[4];
        private SpriteFont font;
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800;
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            this.Window.Title = "click to add text";

            trunk = new Rectangle(375, 300, 50, 200);
            leaves[0] = new Rectangle(300, 275, 110, 110);
            leaves[1] = new Rectangle(370, 250, 130, 120);
            leaves[2] = new Rectangle(370, 230, 90, 90);
            leaves[3] = new Rectangle(330, 235, 85, 85);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            rectTexture = Content.Load<Texture2D>("rectangle");
            circTexture = Content.Load<Texture2D>("circle");
            font = Content.Load<SpriteFont>("font");
             // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.PapayaWhip);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.DrawString(font, "tree moment", new Vector2(160, 40), Color.DarkTurquoise);
            _spriteBatch.Draw(rectTexture, trunk, Color.SaddleBrown);
            foreach (Rectangle leaf in leaves)
                _spriteBatch.Draw(circTexture, leaf, Color.Green);
            _spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
