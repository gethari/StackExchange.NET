using System;
using System.Collections.Generic;

namespace StackExchange.NET.Models
{
	public interface IBaseApiResponse
	{
		bool Status { get; set; }
	}
	public interface IBaseResponse<T> : IBaseApiResponse
	{
		List<T> Items { get; set; }
		bool HasMore { get; set; }
		int QuotaMax { get; set; }
		int QuotaRemaining { get; set; }
	}

	public abstract class BaseApiRequest
	{
		public AnswerFilters AnswerFilters { get; set; }
	}

	public enum Order
	{
		Asc,
		Desc
	}

	public class Filter
	{
		public int? Page { get; set; }
		public int? PageSize { get; set; }
		public DateTime? FromDate { get; set; }
		public DateTime? ToDate { get; set; }
		public Order? Order { get; set; }
		public DateTime? Min { get; set; }
		public DateTime? Max { get; set; }
		public dynamic Sort { get; set; }
		public string Site { get; set; }
	}

}
