namespace StackExchange.NET.Models
{
	public class TagFilter : Filter
	{
		public TagFilter()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.Sort.Creation;
			Site = "stackoverflow";
		}
	}
}