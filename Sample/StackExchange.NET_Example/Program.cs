using System;
using Newtonsoft.Json;
using StackExchange.NET;
using StackExchange.NET.Clients;
using StackExchange.NET.Models;

namespace StackExchange.NET_Example
{
	class Program
	{
		static void Main(string[] args)
		{
			var client = new StackExchangeClient("U4DMV*8nvpm3EOpvf69Rxw((");
			var queryString = new QueryFilters()
			{
				PageSize = 5,
				Page = 5
			};
			var answers = client.Answers.GetAllAnswers(queryString);
			Console.WriteLine(JsonConvert.SerializeObject(answers));
			Console.ReadKey();
		}
	}
}
