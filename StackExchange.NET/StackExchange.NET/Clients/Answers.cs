#region Using Directives

using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace StackExchange.NET.Clients
{
	public class StackExchangeClient : IAnswers
	{
		public IAnswers Answers => this;
		private readonly string _baseApiUrl;
		private readonly HttpClient _httpClient;
		private readonly string _apiKey;
		public StackExchangeClient(string apiKey)
		{
			_apiKey = apiKey;
			_baseApiUrl = $"https://api.stackexchange.com/2.2/answers";
			var httpClientHandler = new HttpClientHandler()
			{
				AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
			};
			_httpClient = new HttpClient(httpClientHandler);

		}
		Answers IAnswers.GetAllAnswers(QueryFilters filters)
		{
			if (filters == null)
				throw new ArgumentNullException($"Null is not a valid parameter");
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var answers = JsonConvert.DeserializeObject<Answers>(response);
			return answers;
		}

		Answers IAnswers.GetAnswerByIds(List<string> ids, QueryFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var answers = JsonConvert.DeserializeObject<Answers>(response);
			return answers;
		}

		public Answers GetCommentsByIds(List<string> ids, QueryFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"/comments?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var answers = JsonConvert.DeserializeObject<Answers>(response);
			return answers;
		}

		public Questions GetQuestionByAnswerIds(List<string> ids, QueryFilters filters)
		{
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}/";
			var idsToEncode = string.Join(";", ids.ToArray());
			url = url + $"{HttpUtility.UrlEncode(idsToEncode)}" + $"/questions?key={_apiKey}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var questions = JsonConvert.DeserializeObject<Questions>(response);
			return questions;
		}

		void IAnswers.AcceptAnAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoAcceptedAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.DeleteAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.DownVoteAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoDownVotedAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.EditAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.GetOptionsOfAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.FlagAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UpVoteAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}

		void IAnswers.UndoUpVotedAnswer(string id, QueryFilters filters)
		{
			throw new NotImplementedException();
		}
	}
}
