#region Using Directives

using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : ISuggestedEdits
	{
		/// <summary>
		/// The SuggestedEdits interface which lists all possible operations.
		/// </summary>
		public ISuggestedEdits SuggestedEdits => this;
		BaseResponse<SuggestedEdits> ISuggestedEdits.GetAllSuggestedEdits(SuggestedEditFilter filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Suggested_Edits)
				.WithFilter(filters)
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<SuggestedEdits>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<SuggestedEdits> ISuggestedEdits.GetSuggestedEditsByIds(List<string> ids,SuggestedEditFilter filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Suggested_Edits)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<SuggestedEdits>>().ValidateApiResponse();
			return response;
		}
	}
}
