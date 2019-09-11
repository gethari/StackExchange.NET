#region Using Directives

using System;
using System.Collections.Generic;
using System.Web;
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
			if (filters == null)
				throw new ArgumentNullException($"Null is not a valid parameter");
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/answers?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Answer>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Answer> IAnswers.GetAnswerByIds(List<string> ids, AnswerFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/answers/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Answer>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Answer> IAnswers.GetCommentsByIds(List<string> ids, AnswerFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/answers/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"/comments?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Answer>>().ValidateApiResponse();
			return apiResult;
		}

		BaseResponse<Question> IAnswers.GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/answers/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"/questions?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var apiResult = response.DeserializeJson<Data<Question>>().ValidateApiResponse();
			return apiResult;
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
