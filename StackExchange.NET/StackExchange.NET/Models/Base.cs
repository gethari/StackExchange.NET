using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace StackExchange.NET.Models
{
	public class BaseResponse<T>
	{
		public bool Success { get; set; }
		public Data<T> Data { get; set; }
		public Exception Exception { get; set; }
		
	}

	public class Data<T>
	{
		[JsonProperty("error_id")]
		public long? ErrorId { get; set; }

		[JsonProperty("error_message")]
		public string ErrorMessage { get; set; }

		[JsonProperty("error_name")]
		public string ErrorName { get; set; }
		[JsonProperty("items")]
		public List<T> Items { get; set; }

		[JsonProperty("has_more")]
		public bool HasMore { get; set; }

		[JsonProperty("quota_max")]
		public long QuotaMax { get; set; }

		[JsonProperty("quota_remaining")]
		public long QuotaRemaining { get; set; }

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
