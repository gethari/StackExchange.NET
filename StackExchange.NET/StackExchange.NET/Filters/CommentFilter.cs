namespace StackExchange.NET.Models
{
	public class CommentFilter : Filter
	{
		public CommentFilter()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.CommentSort.Creation;
			Site = "stackoverflow";
		}
	}
}