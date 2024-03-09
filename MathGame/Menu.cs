namespace MathGame;

internal class Menu
{
	GameEngine engine = new();
	internal void ShowMenu(string? name, DateTime date)
	{

		Console.Clear();
		Console.WriteLine($"Hello {name}. It's {date}. This is your math's game.");
		Console.WriteLine("Press any key to show menu");
		Console.ReadLine();
		var isGameOn = true;
		do
		{
			Console.Clear();
			Console.WriteLine($@"What game would you like to play today? Choose from the options below:
V - View Previous Games
A - Addition
S - Subtraction
M - Multiplication
D - Division 
R - Random
Q - Quit the program");
			Console.WriteLine("-----------------------------------");

			var gameSelected = Console.ReadLine();

			switch (gameSelected.Trim().ToLower())
			{
				case "v":
					Helpers.PrintGames();
					break;
				case "a":
					engine.AdditionGame("Addition game");
					break;
				case "s":
					engine.SubtractionGame("Subtraction game");
					break;
				case "m":
					engine.MultiplicationGame("Multiplication game");
					break;
				case "d":
					engine.DivisionGame("Division game");
					break;
				case "r":
					engine.RandomGame();
					break;
				case "q":
					Console.WriteLine("Goodbye");
					isGameOn = false;
					break;
				default:
					Console.WriteLine("Invalid Input");
					break;
			}
		} while (isGameOn);

	}
	internal static string[] Level()
	{
		var random = new Random();
		int num = 0;
		string data = "";
		do
		{
			Console.Clear();
			Console.WriteLine($@"Choose your Level:
E - Easy
M - Medium
H - Hard
X - Extreme");
			Console.WriteLine("-----------------------------------");
			var level = Console.ReadLine();

			switch (level.Trim().ToLower())
			{
				case "e":
					Console.WriteLine("You chose Easy level");
					num = random.Next(1, 9);
					data = "Easy";
					break;
				case "m":
					Console.WriteLine("You chose Medium level");
					num = random.Next(10, 99);
					data = "Medium";
					break;
				case "h":
					Console.WriteLine("You chose Hard level");
					num = random.Next(100, 999);
					data = "Hard";
					break;
				case "x":
					Console.WriteLine("You chose Extreme level");
					num = random.Next(1000, 9999);
					data = "Extreme";
					break;
				default:
					Console.WriteLine("Invalid Input");
					break;
			}
		} while (num == 0);

		var result = new string[2];
		result[0] = num.ToString();
		result[1] = data;
		return result;
	}
}
