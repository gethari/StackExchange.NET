namespace StackExchange.NET.Models
{
	public class BadgeFilters : Filter
	{
		public BadgeFilters()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.BadgeSort.Name;
			Site = "stackoverflow";
		}
	}
}