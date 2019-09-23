using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class Answer
	{
		[JsonProperty("owner")]
		public Owner Owner { get; set; }

		[JsonProperty("is_accepted")]
		public bool IsAccepted { get; set; }

		[JsonProperty("score")]
		public long Score { get; set; }

		[JsonProperty("last_activity_date")]
		public long LastActivityDate { get; set; }

		[JsonProperty("last_edit_date", NullValueHandling = NullValueHandling.Ignore)]
		public long? LastEditDate { get; set; }

		[JsonProperty("creation_date")]
		public long CreationDate { get; set; }

		[JsonProperty("answer_id")]
		public long AnswerId { get; set; }

		[JsonProperty("question_id")]
		public long QuestionId { get; set; }
	}

	/// <summary>
	/// This filter should be used while using the Answers methods.
	/// </summary>
	public class AnswerFilters : Filter
	{
		public AnswerFilters()
		{
			Order = Models.Order.Desc;
			Sort = Models.Sort.Activity;
			Site = "stackoverflow";
		}
	}
}

