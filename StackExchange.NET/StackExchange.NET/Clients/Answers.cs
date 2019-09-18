#region Using Directives

using System;
using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : IAnswers
	{
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

		BaseResponse<Answer> IAnswers.GetCommentsByIds(List<string> ids, AnswerFilters filters)
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

		void IAnswers.AcceptAnAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoAcceptedAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.DeleteAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.DownVoteAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoDownVotedAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.EditAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.GetOptionsOfAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.FlagAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UpVoteAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoUpVotedAnswer(string id, AnswerFilters filters)
		{
			throw new NotImplementedException();
		}
	}
}
