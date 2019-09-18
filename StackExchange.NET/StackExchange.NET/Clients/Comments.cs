#region Using Directives

using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IComments
	{
		/// <summary>
		/// The Comments interface which lists all possible operations.
		/// </summary>
		public IComments Comments => this;

		BaseResponse<Comment> IComments.GetAllComments(CommentFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Comments)
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Comment>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Comment> IComments.GetCommentsByIds(List<string> commentIds, CommentFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Comments)
				.WithFilter(filters)
				.WithIds(commentIds)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Comment>>().ValidateApiResponse();
			return response;
		}
	}
}
