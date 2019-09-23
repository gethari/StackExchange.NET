using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Question
	{
		[JsonProperty("tags")]
		public List<string> Tags { get; set; }

		[JsonProperty("owner")]
		public Owner Owner { get; set; }

		[JsonProperty("is_answered")]
		public bool IsAnswered { get; set; }

		[JsonProperty("view_count")]
		public long ViewCount { get; set; }

		[JsonProperty("accepted_answer_id")]
		public long AcceptedAnswerId { get; set; }

		[JsonProperty("answer_count")]
		public long AnswerCount { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("last_activity_date")]
		public long LastActivityDate { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("last_edit_date")]
		public long LastEditDate { get; set; }

		[JsonProperty("question_id")]
		public long QuestionId { get; set; }

		[JsonProperty("link")]
		public Uri Link { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}

	public enum QuestionSort
	{
		Activity,
		Votes,
		Creation,
		Hot,
		Week,
		Month
	}

	public class QuestionFilters : Filter
	{
		public QuestionFilters()
		{
			Order = Models.Order.Desc;
			Sort = QuestionSort.Hot;
			Site = "stackoverflow";
		}
	}
}
