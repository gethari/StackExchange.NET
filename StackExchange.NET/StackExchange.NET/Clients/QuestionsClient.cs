using System;
using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IQuestions
	{
		/// <summary>
		/// StackExchangeClient used to perform operations on APIs.
		/// </summary>
		public IQuestions Questions => this;
		BaseResponse<Question> IQuestions.GetAllQuestions(QuestionFilters filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetQuestionsByIds(List<string> ids, QuestionFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Answer> IQuestions.GetAnswersByQuestionIds(List<string> ids, QuestionFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Answer>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Comment> IQuestions.GetCommentsByQuestionIds(List<string> ids, QuestionFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.WithIds(ids)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Comment>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetLinkedQuestions(List<string> ids, QuestionFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.WithIds(ids,"linked")
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetRelatedQuestions(List<string> ids, QuestionFilters filters)
		{
			var url = ApiUrlBuilder.Initialize(_apiKey)
				.ForClient(ClientType.Questions)
				.WithFilter(filters)
				.WithIds(ids,"related")
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetTimeLine(List<string> ids, QuestionFilters filters)
		{
			throw new NotImplementedException();
		}

		BaseResponse<Question> IQuestions.GetFeaturedQuestions(QuestionFilters filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Questions,"featured")
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetQuestionsWithNoAnswers(QuestionFilters filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Questions,"no-answers")
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> IQuestions.GetUnansweredQuestions(QuestionFilters filters)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Questions,"unanswered")
				.WithFilter(filters)
				.GetApiUrl();
			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}
	}
}
