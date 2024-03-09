﻿namespace MathGame.Models;

internal class Game
{
	public int Score { get; set; }
	public DateTime Date { get; set; }
	public GameType Type { get; set; }
	public string Level { get; set; }
}

internal enum GameType
{
	Addition,
	Subtraction,
	Multiplication,
	Division
}

