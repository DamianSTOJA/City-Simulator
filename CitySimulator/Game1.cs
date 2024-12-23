using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using CitySimulator.GameObjects.Grid;
using CitySimulator.SaveLoad;
using CitySimulator.Renderer;
namespace CitySimulator;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch spriteBatch;

    private GridManager gridManager;
    private GridRenderer gridRenderer;
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        NewGame newGame = new(20, 20);
        gridManager = new GridManager(newGame.GetGameState());

        base.Initialize();
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
        gridRenderer = new GridRenderer(gridManager.GetGrid(), GraphicsDevice);

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
        GraphicsDevice.Clear(Color.CornflowerBlue);
        spriteBatch.Begin();
        gridRenderer.Draw(spriteBatch);
        spriteBatch.End();
        // TODO: Add your drawing code here
        
        base.Draw(gameTime);
    }
}
