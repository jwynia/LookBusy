using System;
using Bogus;
using McMaster.Extensions.CommandLineUtils;

namespace LookBusy
{
	[Command(Name="look-busy", Description = "Sometimes, computers need to look busy."),
	 Subcommand(typeof(TransferData))
	]
	class Program
	{
		public static int Main(string[] args) => CommandLineApplication.Execute<Program>(args);
		private int OnExecute(CommandLineApplication app, IConsole console)
		{
			Logger.LogError("Specify at a subcommand.");
			app.ShowHelp();
			return 1;
		}
	}
}