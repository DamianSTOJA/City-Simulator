using CitySimulator.GameObjects.Cells;
namespace CitySimulator.GameObjects;
public class GameState(ICell[,] _grid)
{
    private ICell [,] grid = _grid;

    public ICell [,] GetGrid() {
        return grid;
    }
}