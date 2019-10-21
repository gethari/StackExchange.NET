namespace StackExchange.NET.Models
{
	public class PostFilter : Filter
	{
		public PostFilter()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.PostSort.Creation;
			Site = "stackoverflow";
		}
	}
}