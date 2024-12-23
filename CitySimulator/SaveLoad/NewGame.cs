namespace CitySimulator.SaveLoad;
using CitySimulator.GameObjects.Cells;
using CitySimulator.GameObjects;

public class NewGame {
    private int x;
    private int y;
    private GameState gameState;
    ICell [,] grid;
    public NewGame(int _x, int _y) {
        x = _x;
        y = _y;
        gameState = SetEmptyGrid();
    }
    public GameState GetGameState() {
        return gameState;
    }

    public GameState SetEmptyGrid() {
        grid = new ICell[x, y];
        for (int i = 0; i < x; i++) {
            for (int j = 0; j < y; j++) {
                grid[i, j] = new EmptyCell();
            }
        }
        return new GameState(grid);
    }
}