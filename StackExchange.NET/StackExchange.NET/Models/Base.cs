using System;
using System.Collections.Generic;

namespace StackExchange.NET.Models
{
	public interface IBaseApiResponse
	{
		bool Status { get; set; }
	}
	public interface IBase<T> : IBaseApiResponse
	{
		List<T> Items { get; set; }
		bool HasMore { get; set; }
		int QuotaMax { get; set; }
		int QuotaRemaining { get; set; }
	}

	public abstract class BaseApiRequest
	{
		public QueryFilters QueryFilters { get; set; }
	}

	public class QueryFilters
	{
		public QueryFilters()
		{
			Order = Models.Order.Desc;
			Sort = Models.Sort.Activity;
			Site = "stackoverflow";
		}
		public int? Page { get; set; }
		public int? PageSize { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? Min { get; set; }
		public DateTime? Max { get; set; }
		public DateTime? ToDate { get; set; }
		public string Id { get; set; }
		public Order? Order { get; set; }
		public Sort? Sort { get; set; }
		public string Site { get; set; }
	}

	public class ApiParams
	{
		public int? Page { get; set; }
		public int? PageSize { get; set; }
		public long? FromDate { get; set; }
		public long? Min { get; set; }
		public long? Max { get; set; }
		public long? ToDate { get; set; }
		public string Id { get; set; }
		public string Order { get; set; }
		public string Sort { get; set; }
		public string Site { get; set; }
	}

	public enum Order
	{
		Asc,
		Desc
	}

	public enum Sort
	{
		Activity,
		Votes,
		Creation
	}
}
