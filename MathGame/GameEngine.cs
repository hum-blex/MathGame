using MathGame.Models;

namespace MathGame;

internal class GameEngine
{

	internal void AdditionGame(string message)
	{
		Console.WriteLine(message);
		var random = new Random();
		var score = 0;
		var level = Menu.Level();
		var high = int.Parse(level[0]);
		Console.Clear();
		Console.WriteLine("How many questions do you want to pick?");
		var questions = Console.ReadLine();
		questions = Helpers.GetNumberOfQuestions(questions);
		var watch = new System.Diagnostics.Stopwatch();
		watch.Start();
		for (int i = 0; i < int.Parse(questions); i++)
		{
			Console.Clear();
			var firstNumber = random.Next(1, high);
			var secondNumber = random.Next(1, high);

			Console.WriteLine($"{firstNumber} + {secondNumber}");
			var result = Console.ReadLine();

			result = Helpers.ValidateResult(result);
			if (int.Parse(result) == firstNumber + secondNumber)
			{
				Console.WriteLine("Your answer was correct.Type any key for the next question");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Your answer was incorrect.Type any key for the next question");
				Console.ReadLine();
			}

			if (i == int.Parse(questions) - 1)
			{
				Console.WriteLine($"Game Over. Your final score is {score}.Press any key to go back to main menu");
				Console.ReadLine();
			}
		}
		watch.Stop();
		Helpers.AddToHistory(score, GameType.Addition, level[1], watch.ElapsedMilliseconds);

	}
	internal void SubtractionGame(string message)
	{
		Console.WriteLine(message);
		var random = new Random();
		var score = 0;
		var level = Menu.Level();
		var high = int.Parse(level[0]);
		Console.Clear();
		Console.WriteLine("How many questions do you want to pick?");
		var questions = Console.ReadLine();
		questions = Helpers.GetNumberOfQuestions(questions);
		var watch = new System.Diagnostics.Stopwatch();
		watch.Start();
		for (int i = 0; i < int.Parse(questions); i++)
		{
			Console.Clear();
			var firstNumber = random.Next(1, high);
			var secondNumber = random.Next(1, high);

			Console.WriteLine($"{firstNumber} - {secondNumber}");
			var result = Console.ReadLine();
			result = Helpers.ValidateResult(result);
			if (int.Parse(result) == firstNumber - secondNumber)
			{
				Console.WriteLine("Your answer was correct.Type any key for the next question");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Your answer was incorrect.Type any key for the next question");
				Console.ReadLine();
			}

			if (i == int.Parse(questions) - 1)
			{
				Console.WriteLine($"Game Over. Your final score is {score}.Press any key to go back to main menu");
				Console.ReadLine();
			}
		}
		watch.Stop();
		Helpers.AddToHistory(score, GameType.Subtraction, level[1], watch.ElapsedMilliseconds);
	}
	internal void MultiplicationGame(string message)
	{
		Console.WriteLine(message);
		var random = new Random();
		var score = 0;
		var level = Menu.Level();
		var high = int.Parse(level[0]);
		Console.Clear();
		Console.WriteLine("How many questions do you want to pick?");
		var questions = Console.ReadLine();
		questions = Helpers.GetNumberOfQuestions(questions);
		var watch = new System.Diagnostics.Stopwatch();
		watch.Start();
		for (int i = 0; i < int.Parse(questions); i++)
		{
			Console.Clear();
			var firstNumber = random.Next(1, high);
			var secondNumber = random.Next(1, high);
			Console.WriteLine($"{firstNumber} * {secondNumber}");
			var result = Console.ReadLine();
			result = Helpers.ValidateResult(result);
			if (int.Parse(result) == firstNumber * secondNumber)
			{
				Console.WriteLine("Your answer was correct.Type any key for the next question");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Your answer was incorrect.Type any key for the next question");
				Console.ReadLine();
			}

			if (i == int.Parse(questions) - 1)
			{
				Console.WriteLine($"Game Over. Your final score is {score}.Press any key to go back to main menu");
				Console.ReadLine();
			}
		}
		watch.Stop();
		Helpers.AddToHistory(score, GameType.Multiplication, level[1], watch.ElapsedMilliseconds);
	}
	internal void DivisionGame(string message)
	{
		var score = 0;
		var level = Menu.Level();
		var high = int.Parse(level[0]);
		Console.Clear();
		Console.WriteLine("How many questions do you want to pick?");
		var questions = Console.ReadLine();
		questions = Helpers.GetNumberOfQuestions(questions);
		var watch = new System.Diagnostics.Stopwatch();
		watch.Start();
		for (int i = 0; i < int.Parse(questions); i++)
		{
			Console.Clear();
			var divisionNumbers = Helpers.GetDivisionNumbers(high);
			var firstNumber = divisionNumbers[0];
			var secondNumber = divisionNumbers[1];
			Console.WriteLine($"{firstNumber}/{secondNumber}");
			var result = Console.ReadLine();
			result = Helpers.ValidateResult(result);
			if (int.Parse(result) == firstNumber / secondNumber)
			{
				Console.WriteLine("Your answer was correct.Type any key for the next question");
				score++;
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("Your answer was incorrect.Type any key for the next question");
				Console.ReadLine();
			}

			if (i == int.Parse(questions) - 1)
			{
				Console.WriteLine($"Game Over. Your final score is {score}.Press any key to go back to main menu");
				Console.ReadLine();
			}

		}
		watch.Stop();
		Helpers.AddToHistory(score, GameType.Division, level[1], watch.ElapsedMilliseconds);
	}

	internal void RandomGame()
	{
		var random = new Random();
		var rand = random.Next(1, 4);
		if (rand == 1) AdditionGame("Addition game");
		else if (rand == 2) SubtractionGame("Subtraction game");
		else if (rand == 3) MultiplicationGame("Multiplication game");
		else DivisionGame("Division game");
	}
}
