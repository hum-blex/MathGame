using MathGame.Models;

namespace MathGame;

internal class Helpers
{
	internal static List<Game> games = new();
	internal static void AddToHistory(int gameScore, GameType gameType, string gameLevel, long time)
	{
		games.Add(new Game
		{
			Date = DateTime.Now,
			Score = gameScore,
			Type = gameType,
			Level = gameLevel,
			Time = time
		});

	}
	internal static void PrintGames()
	{

		Console.Clear();
		Console.WriteLine("Games History");
		Console.WriteLine("-----------------------------------");
		foreach (var game in games)
		{
			Console.WriteLine($"{game.Date}-{game.Type}:{game.Score} pts, Level :{game.Level}  {game.Time} milliseconds");
		}
		Console.WriteLine("-----------------------------------\n");
		Console.WriteLine("Press any key to return to Main Menu");
		Console.ReadLine();
	}
	internal static int[] GetDivisionNumbers(int high)
	{
		var random = new Random();
		var firstNumber = random.Next(1, high);
		var secondNumber = random.Next(1, high);

		var result = new int[2];


		while (firstNumber % secondNumber != 0)
		{
			firstNumber = random.Next(1, high);
			secondNumber = random.Next(1, high);
		}
		result[0] = firstNumber;
		result[1] = secondNumber;


		return result;
	}

	internal static string? ValidateResult(string result)
	{
		while (string.IsNullOrEmpty(result) || !Int32.TryParse(result, out _))
		{
			Console.WriteLine("Your answer needs to be an integer. Try again.");
			result = Console.ReadLine();
		}
		return result;
	}

	internal static string GetName()
	{

		Console.WriteLine("Please provide your name");
		var name = Console.ReadLine();
		while (string.IsNullOrEmpty(name))
		{
			Console.WriteLine("Name can't be empty");
			name = Console.ReadLine();
		}
		return name;
	}

	internal static string GetNumberOfQuestions(string questions)
	{

		while (string.IsNullOrEmpty(questions) || !Int32.TryParse(questions, out _))
		{
			Console.WriteLine("Your answer needs to be an integer. Try again.");
			questions = Console.ReadLine();
		};
		return questions;
	}
}

