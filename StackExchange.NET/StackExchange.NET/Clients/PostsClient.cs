#region Using Directives

using System;
using System.Collections.Generic;
using System.Web;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IPosts
	{
		public IPosts Posts => this;

		BaseResponse<Post> IPosts.GetAllPosts(PostFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Posts)
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Post>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Post> IPosts.GetAllPostsByIds(List<string> ids, PostFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Posts)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Post>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Post> IPosts.GetCommentsOnPosts(List<string> ids, PostFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Posts)
				.WithFilter(filters)
				.WithIds(ids, "comments")
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Post>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Post> IPosts.GetRevisionsByIds(List<string> ids, PostFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Posts)
				.WithFilter(filters)
				.WithIds(ids, "revisions")
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Post>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Post> IPosts.GetSuggestedEdits(List<string> ids, SuggestedEditFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
						.ForClient(ClientType.Posts)
						.WithFilter(filters)
						.WithIds(ids, "suggested-edits")
						.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Post>>().ValidateApiResponse();
			return response;
		}
	}
}
