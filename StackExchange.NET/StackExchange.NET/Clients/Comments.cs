using System;
using System.Collections.Generic;
using System.Web;
using Newtonsoft.Json;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IComments
	{
		public IComments Comments => this;

		Comments IComments.GetAllComments(CommentFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/comments?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var comments = JsonConvert.DeserializeObject<Comments>(response);
			return comments;
		}

		Comments IComments.GetCommentsByIds(List<string> commentIds, CommentFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/comments/";
			var idsToEncode = string.Join(";", commentIds.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var comments = JsonConvert.DeserializeObject<Comments>(response);
			return comments;
		}
	}
}
