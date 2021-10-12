using Xunit;

namespace ChessBoard.Tests
{
    public class BoardTests
    {
        Board board = new Board();

        [Theory]
        [InlineData(0, 0, Color.Black)]
        [InlineData(1, 0, Color.White)]
        [InlineData(0, 1, Color.White)]
        [InlineData(7, 7, Color.Black)]
        public void BoardColorsAreCorrect(int x, int y, Color color)
        {
            Assert.Equal(color, board.Squares[x, y].Color);

        }
    }
}