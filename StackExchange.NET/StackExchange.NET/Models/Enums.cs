namespace StackExchange.NET.Models
{
	public class Enums
	{
		public enum Order
		{
			Asc,
			Desc
		}
		public enum BadgeSort
		{
			Rank,
			Name,
			Type
		}
		public enum CommentSort
		{
			Creation,
			Votes
		}
		public enum PostSort
		{
			Votes,
			Creation
		}

		public enum PostType
		{
			Answer, Question
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

		public enum Sort
		{
			Activity,
			Votes,
			Creation
		}

		public enum SuggestedEdit
		{
			Creation,
			Approval,
			Rejection
		}

		public enum TagSort
		{
			Popular,
			Activity,
			Name
		}
		public enum UserType
		{
			Registered
		}
	}
}
