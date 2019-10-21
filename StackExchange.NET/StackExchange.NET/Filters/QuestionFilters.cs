namespace StackExchange.NET.Models
{
	public class QuestionFilters : Filter
	{
		public QuestionFilters()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.QuestionSort.Hot;
			Site = "stackoverflow";
		}
	}
}