using System.Security.Cryptography;
using System.Threading;
using Bogus.DataSets;
using McMaster.Extensions.CommandLineUtils;

namespace LookBusy
{
	[Command(Name="transfer-data", Description = "There's data that needs transferring. Watch it go by.")]
	public class TransferData
	{
		public void OnExecute()
		{
			Logger.LogSuccess("Press CTRL+C to stop");
			Thread.Sleep(1000);
			while (true)
			{
				var hacker = new Hacker();
				var internet = new Internet();
				var diceRoll = new Bogus.Randomizer().Number(0,6);
				Logger.Log($"Loading {hacker.Noun()} from {hacker.Noun()}");
				Logger.Log($"{hacker.IngVerb()} data to {hacker.Noun()} at: {internet.IpAddress()} ");
				if (diceRoll == 4)
				{
					Logger.LogError($"Failure to process. See error code: {internet.Ipv6EndPoint()}");
				}

				if (diceRoll % 3 == 0)
				{
					Logger.LogSuccess($"Processing succeeded for {internet.Mac()}");
				}
				Logger.Log($"");
				Thread.Sleep(350);
			}
		}
	}
}