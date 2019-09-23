#region Using Directives

using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	/// <summary>
	/// StackExchangeClient used to perform operations on APIs.
	/// </summary>
	public partial class StackExchangeClient : IAnswers
	{
		/// <summary>
		/// The Answers interface which lists all possible operations.
		/// </summary>
		public IAnswers Answers => this;
		BaseResponse<Answer> IAnswers.GetAllAnswers(AnswerFilters filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Answers)
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Answer>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Answer> IAnswers.GetAnswerByIds(List<string> ids, AnswerFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Answers)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Answer>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Answer> IAnswers.GetCommentsOnAnswers(List<string> ids, AnswerFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Answers)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Answer>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IAnswers.GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Answers)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

	}
}
