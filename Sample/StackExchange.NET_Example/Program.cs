using System;
using System.Collections.Generic;
using Newtonsoft.Json;
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
				PageSize = 1,
				Page = 1,
				Sort = Sort.Votes
			};
			//var answers = client.Answers.GetAllAnswers(queryString);
			var ids = new List<string>()
			{
				"44164379","6841479"
			};
			//var answers = client.Answers.GetAnswerByIds(ids, queryString);
			//var answers = client.Answers.GetCommentsByIds(ids, queryString);
			var answers = client.Answers.GetQuestionByAnswerIds(ids, queryString);
			Console.WriteLine(JsonConvert.SerializeObject(answers));
			Console.ReadKey();
		}
	}
}
