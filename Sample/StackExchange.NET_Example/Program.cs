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
			var queryString = new AnswerFilters()
			{
				PageSize = 1,
				Page = 1,
				Sort = AnswerSort.Votes
			};
			//var answers = client.Answers.GetAllAnswers(queryString);
			var ids = new List<string>()
			{
				"44164379","6841479"
			};
			//var answers = client.Answers.GetAnswerByIds(ids, queryString);
			//var answers = client.Answers.GetCommentsByIds(ids, queryString);
			//var answers = client.Answers.GetQuestionByAnswerIds(ids, queryString);

			var badgeFilter = new BadgeFilters()
			{
				Sort = BadgeSort.Name
			};
			//var badges = client.Badges.GetAllBadges(badgeFilter);

			var batchIds = new List<string>()
			{
				"4600","2600","26"
			};

			//var getBadgesByIds = client.Badges.GetBadgesByIds(batchIds, badgeFilter);
			//var getBadgesByIds = client.Badges.GetRecentlyAwardedBadges(badgeFilter);

			//var getBadgesByIds = client.Badges.GetRecentlyAwardedBadgesByIds(batchIds, badgeFilter);

			var getBadgesByIds = client.Badges.GetAllTaggedBadges(badgeFilter);
			Console.WriteLine(JsonConvert.SerializeObject(getBadgesByIds));
			Console.ReadKey();
		}
	}
}
