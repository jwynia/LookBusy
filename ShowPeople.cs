using System;
using System.Diagnostics;
using System.Threading;
using Bogus;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.VisualBasic;

namespace LookBusy
{
	[Command(Name = "show-people",Description = "Take a look at these people.")]
	public class ShowPeople
	{
		public void OnExecute()
		{
			Logger.LogSuccess("Press CTRL+C to stop");
			var people = new Faker<Bogus.Person>().GenerateForever();
			int counter = 25000;
			while(true)
			{
				var stopwatch = new Stopwatch();
				stopwatch.Start();
				var person = new Bogus.Person();
				counter++;
				Logger.Log($"Personnel record processing number: {counter}");
				Logger.Log($"	{person.FullName}");
				Logger.Log($"	{person.Email} {person.Gender}");
				Logger.Log($"	{person.DateOfBirth}");
				Logger.Log($"	{person.Address.Street}");
				Logger.Log($"	{person.Address.City} {person.Address.State} {person.Address.ZipCode}");
				Logger.Log($"	{person.Phone}");
				
				stopwatch.Stop();
				Logger.LogSuccess($"	Completed record processing in {stopwatch.ElapsedTicks} ticks.");
				Thread.Sleep(200);
			}
		}
	}
}