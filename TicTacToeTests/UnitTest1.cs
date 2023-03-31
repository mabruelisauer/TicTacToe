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
        public void TestInput()
        {
            // Create a new instance of the Tic Tac Toe game
            var gameUI = new GameUI();


            // Create a string array representing the user input
            string[] input = { "1c", "2b", "3a" };

            // Use a StringWriter to capture the console output
            StringWriter stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            // Use a StringReader to simulate user input
            StringReader stringReader = new StringReader(string.Join(Environment.NewLine, input));
            Console.SetIn(stringReader);

            // Start the game and run it to completion
            gameUI.StartGame();

            // Verify the console output
            Console.Clear();
            string expectedOutput = string.Join("", new[] {

            "       A   B   C  \n",
            "     -------------\n",
            "  01 |   |   |   |\n",
            "     -------------\n",
            "  02 |   |   |   |\n",
            "     -------------\n",
            "  03 |   |   |   |\n",
            "     -------------\n",
            "Player 1: select a field you would like to claim by entering it's coordinates. For example: 1A for the first field.",
            "\n"
        });

            Console.Clear();

            expectedOutput += string.Join("", new[] {

            "       A   B   C  \n",
            "     -------------\n",
            "  01 |   |   | X |\n",
            "     -------------\n",
            "  02 |   |   |   |\n",
            "     -------------\n",
            "  03 |   |   |   |\n",
            "     -------------\n",
            "Player 2: select a field you would like to claim by entering it's coordinates. For example: 1A for the first field.",
            "\n"
        });

            Console.Clear();

            expectedOutput += string.Join("", new[] {

            "       A   B   C  \n",
            "     -------------\n",
            "  01 |   |   | X |\n",
            "     -------------\n",
            "  02 |   | O |   |\n",
            "     -------------\n",
            "  03 |   |   |   |\n",
            "     -------------\n",
            "Player 1: select a field you would like to claim by entering it's coordinates. For example: 1A for the first field.",
            "\n"
        });

            Console.Clear();

            expectedOutput += string.Join("", new[] {

            "       A   B   C  \n",
            "     -------------\n",
            "  01 |   |   | X |\n",
            "     -------------\n",
            "  02 |   | O |   |\n",
            "     -------------\n",
            "  03 | X |   |   |\n",
            "     -------------\n",
            "Player 2: select a field you would like to claim by entering it's coordinates.",
            "\n"
        });




            Assert.AreEqual(expectedOutput, stringWriter.ToString());

            stringReader.Dispose();
            stringWriter.Dispose();
        }
    }

}