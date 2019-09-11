﻿#region Using Directives

using System.Collections.Generic;
using System.Web;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IPosts
	{
		public IPosts Posts => this;

		BaseResponse<Posts> IPosts.GetAllPosts(PostFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/posts?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Posts>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Posts> IPosts.GetAllPostsByIds(List<string> ids, PostFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/posts/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Posts>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Posts> IPosts.GetCommentsOnPosts(List<string> ids, PostFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/posts/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}/comments" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Posts>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Posts> IPosts.GetRevisionsByIds(List<string> ids, PostFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/posts/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}/revisions" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Posts>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Posts> IPosts.GetSuggestedEdits(List<string> ids, SuggestedEditFilter filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/posts/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}/suggested-edits" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Posts>>().ValidateApiResponse();
			return apiResult;
		}
	}
}