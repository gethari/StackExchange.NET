namespace StackExchange.NET.Models
{
	/// <summary>
	/// This filter should be used while using the Answers methods.
	/// </summary>
	public class AnswerFilters : Filter
	{
		public AnswerFilters()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.Sort.Activity;
			Site = "stackoverflow";
		}
	}
}