
using CitySimulator.GameObjects.Cells;
using CitySimulator.Util;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace CitySimulator.Renderer;
    public class GridRenderer {
        private readonly int side = Constants.cellSize;
        private ICell [,] grid;
        private GraphicsDevice graphicsDevice;

        private Texture2D squareTexture;

        public GridRenderer(ICell[,] _grid, GraphicsDevice _graphicsDevice) 
        {
            grid = _grid;
            graphicsDevice = _graphicsDevice;
            squareTexture = CreateEmptySquareTexture();
        }

        public Texture2D CreateEmptySquareTexture() {
            squareTexture = new Texture2D(graphicsDevice, side, side);
            Color[] data = new Color[side * side];

            for (int i = 0; i < data.Length; ++i)
            {
                data[i] = Color.Green;
            }

            squareTexture.SetData(data);
            return squareTexture;

        }
        // draws empty cells in a row
        public void Draw(SpriteBatch spriteBatch) {
            var position = new Vector2(0,0);
            foreach(ICell cell in grid) {
                spriteBatch.Draw(squareTexture, position, Color.Green);    
                position.X += side;
            }
        }
    /*
        //this only draws one square right now
        public void Draw(SpriteBatch spriteBatch) {
            var position = new Vector2(0, 0);

            spriteBatch.Draw(squareTexture, position, Color.Green);    
        }
        */

    }

