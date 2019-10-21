using System;

namespace StackExchange.NET.Models
{
	public class Filter
	{
		public Filter()
		{
			Order = Enums.Order.Desc;
			Site = "stackoverflow";
			Sort = Enums.Sort.Activity;
		}
		public int? Page { get; set; }
		public int? PageSize { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public Enums.Order? Order { get; set; }
		public DateTime? Min { get; set; }
		public DateTime? Max { get; set; }
		public dynamic Sort { get; set; }
		public string Site { get; set; }
	}
}