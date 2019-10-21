namespace StackExchange.NET.Models
{
	public class SuggestedEditFilter : Filter
	{
		public SuggestedEditFilter()
		{
			Order = Enums.Order.Desc;
			Sort = Enums.SuggestedEdit.Creation;
			Site = "stackoverflow";
		}
	}
}