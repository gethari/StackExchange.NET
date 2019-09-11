#region Using Directives

using System.Collections.Generic;
using System.Web;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IComments
	{
		public IComments Comments => this;

		BaseResponse<Comment> IComments.GetAllComments(CommentFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/comments?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Comment>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Comment> IComments.GetCommentsByIds(List<string> commentIds, CommentFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/comments/";
			var idsToEncode = string.Join(";", commentIds.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Comment>>().ValidateApiResponse();
			return apiResult;
		}
	}
}
