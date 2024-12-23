namespace CitySimulator.GameObjects.Grid;
using CitySimulator.GameObjects.Cells;
public class GridManager {
    private GameState gameState; 
    public GridManager(GameState _gameState) {
        gameState = _gameState;
    }
  
    public ICell [,] GetGrid() {
        return gameState.GetGrid();
    }
    
}