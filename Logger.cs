using System;

namespace LookBusy
{
	public static class Logger
	{
		public static void Log(string message)
		{
			Console.WriteLine(message);
		}

		public static void Log(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Log(message);
			Console.ForegroundColor = restoreColor;
		}

		public static void LogError(string message)
		{
			Log(message, ConsoleColor.Red);
		}
        
		public static void LogSuccess(string message)
		{
			Log(message, ConsoleColor.Green);
		}
	}
}