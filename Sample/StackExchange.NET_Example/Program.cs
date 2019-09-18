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
			var client = new StackExchangeClient("yourApiKey");
			var queryString = new AnswerFilters()
			{
				PageSize = 1,
				Page = 1,
				Sort = Sort.Votes
			};
		//	var answers = client.Answers.GetAllAnswers(queryString);
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
			//var getBadgesByIds = client.Badges.GetNonTaggedBadges(batchIds, badgeFilter);
			//var getBadgesByIds = client.Badges.GetBadgesByIds(batchIds, badgeFilter);
			//var getBadgesByIds = client.Badges.GetRecentlyAwardedBadges(badgeFilter);
			
		//	var getBadgesByIds = client.Badges.GetRecentlyAwardedBadgesByIds(batchIds, badgeFilter);

			//var getBadgesByIds = client.Badges.GetAllTaggedBadges(badgeFilter);
			//Console.WriteLine(JsonConvert.SerializeObject(getBadgesByIds));

			var commentFilter = new CommentFilter()
			{
				Sort = CommentSort.Creation
			};
			//var comments = client.Comments.GetAllComments(commentFilter);

			var commentIds = new List<string>()
						{
								"102165885", "102166303"
						};
			//var comments = client.Comments.GetCommentsByIds(commentIds,commentFilter);
			//Console.WriteLine(JsonConvert.SerializeObject(comments));

			var postFilter = new PostFilter()
			{
				Sort = PostSort.Creation
			};
			//var posts = client.Posts.GetAllPosts(postFilter);

			var postIds = new List<string>()
						{
								"57871119", "57698255"
						};

			//var postsByIds = client.Posts.GetAllPostsByIds(postIds, postFilter);


			//var postsByIds = client.Posts.GetCommentsOnPosts(postIds, postFilter);

		//	var revisionByIds = client.Posts.GetRevisionsByIds(postIds, postFilter);

			 var suggestedEdits = client.Posts.GetSuggestedEdits(postIds, new SuggestedEditFilter()
			 {
			 	Sort = PostSort.Creation
			 });

			Console.WriteLine(JsonConvert.SerializeObject(suggestedEdits));
			Console.ReadKey();
		}
	}
}
