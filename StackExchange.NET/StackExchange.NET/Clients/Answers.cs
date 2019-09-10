using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using StackExchange.NET.Answers;
using StackExchange.NET.Models;

namespace StackExchange.NET.Clients
{
	public class StackExchangeClient : IAnswers
	{
		public IAnswers Answers => this;
		private readonly string _baseApiUrl;
		private readonly HttpClient _httpClient;
		public StackExchangeClient(string apiKey)
		{
			_baseApiUrl = $"https://api.stackexchange.com/2.2/answers?key={apiKey}";
			var httpClientHandler = new HttpClientHandler()
			{
				AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
			};
			_httpClient = new HttpClient(httpClientHandler);

		}
		Models.Answers IAnswers.GetAllAnswers(QueryFilters filters)
		{
			if(filters==null)
				throw new ArgumentNullException($"Null is not a valid parameter");
			var apiParams = filters.GetQueryParams();
			var url = $"{_baseApiUrl}&{apiParams}";
			var response = _httpClient.GetAsync(url).Result.Content.ReadAsStringAsync().Result;
			var answers = JsonConvert.DeserializeObject<Models.Answers>(response);
			return answers;
		}

		void IAnswers.GetAnswerById(List<string> ids, QueryFilters filters)
		{
			throw new NotImplementedException();
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
