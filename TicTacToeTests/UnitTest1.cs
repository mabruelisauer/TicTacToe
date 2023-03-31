using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace TicTacToe
{
    [TestClass]
    public class TicTacToeGameTests
    {
        [TestMethod]
        public void TestValidInput()
        {
            //Arrange
            GameUI gameUI = new GameUI();
            string input = "b2";
            Coordinate expectedCoordinate = new Coordinate(1, 1);
            StringReader stringReader = new StringReader(input);
            Console.SetIn(stringReader);

            //Act
            Coordinate actualCoordinate = gameUI.GetCoordinate(3);

            string actualCoordinateString = actualCoordinate.ToString();
            string expectedCoordinateString = expectedCoordinate.ToString();
            // Assert
            Assert.AreEqual(expectedCoordinateString, actualCoordinateString);
        }

        [TestMethod]
        public void TestInvalidInput()
        {
            // Arrange
            bool isValid;
            Coordinate coordinate;
            string input = "d1";

            // Act
            (isValid, coordinate) = Coordinate.TryCreateCoordinate(input, 3);

            // Assert
            Assert.IsNull(coordinate);
        }

        [TestMethod]
        public void TestWinCondition()
        {
            // Arrange
            GameUI gameUI = new GameUI();
            string expectedOutput = "Player 1 has won the game!";
            StringReader stringReader = new StringReader("1a\n2a\n1b\n2b\n1c\ngg\n");
            StringWriter stringWriter = new StringWriter();
            
            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            gameUI.StartGame();

            string output = stringWriter.ToString();

            // Assert
            Assert.IsTrue(output.Contains(expectedOutput));
        }

        [TestMethod]
        public void TestDraw()
        {
            // Arrange
            GameUI gameUI = new GameUI();
            string expectedOutput = "Draw!";
            StringReader stringReader = new StringReader("1a\n2a\n1b\n2b\n2c\n1c\na3\nb3\nc3");
            StringWriter stringWriter = new StringWriter();

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            gameUI.StartGame();

            string output = stringWriter.ToString();

            // Assert
            Assert.IsTrue(output.Contains(expectedOutput));
        }

        [TestMethod]
        public void TestDoubleInput()
        {
            // Arrange
            GameUI gameUI = new GameUI();
            string expectedOutput = "This Field is already in use, please choose another one";
            StringReader stringReader = new StringReader("1a\n1a\nende\n");
            StringWriter stringWriter = new StringWriter();

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            gameUI.StartGame();

            string output = stringWriter.ToString();

            // Assert
            Assert.IsTrue(output.Contains(expectedOutput));
        }



        [TestMethod]
        public void TestRestartInput()
        {
            // Arrange
            GameUI gameUI = new GameUI();
            string expectedOutput = "The game was restarted!";
            StringReader stringReader = new StringReader("1a\nneu\n1a\nende\n");
            StringWriter stringWriter = new StringWriter();

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            gameUI.StartGame();

            string output = stringWriter.ToString();

            // Assert
            Assert.IsTrue(output.Contains(expectedOutput));
        }

        [TestMethod]
        public void TestEndingInput()
        {
            // Arrange
            GameUI gameUI = new GameUI();
            string expectedOutput = "The game was ended!";
            StringReader stringReader = new StringReader("1a\nende\n");
            StringWriter stringWriter = new StringWriter();

            Console.SetIn(stringReader);
            Console.SetOut(stringWriter);

            // Act
            gameUI.StartGame();

            string output = stringWriter.ToString();

            // Assert
            Assert.IsTrue(output.Contains(expectedOutput));
        }
    }
}