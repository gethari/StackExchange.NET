using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient : ITags
	{
		public ITags Tags => this;
		BaseResponse<Tags> ITags.GetAllTags(TagFilter filter)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithFilter(filter)
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Tags>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Tags> ITags.GetTagsByNames(List<string> tags, TagFilter filter)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithFilter(filter)
				.WithIds(tags,"info")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Tags>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Tags> ITags.GetModeratorOnlyTags(TagFilter filter)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags,"moderator-only")
				.WithFilter(filter)
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Tags>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<TagSynonyms> ITags.GetAllTagSynonyms(TagFilter filter)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags,"synonyms")
				.WithFilter(filter)
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<TagSynonyms>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Question> ITags.GetFrequentlyAskedQuestions(List<string> tags)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithIds(tags,"faq")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Question>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<Tags> ITags.GetRelatedTags(List<string> tags)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithIds(tags,"related")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<Tags>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<TagSynonyms> ITags.GetSynonymsForTags(List<string> tags, TagFilter filter)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithFilter(filter)
				.WithIds(tags,"synonyms")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<TagSynonyms>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<TagScore> ITags.GetTopAnswerersPosts(string tag, string period)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithTagAndPeriod(tag, $"top-answerers/{period}")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<TagScore>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<TagScore> ITags.GetTopAskers(string tag, string period)
		{
			var url = ApiUrlBuilder
				.Initialize(_apiKey)
				.ForClient(ClientType.Tags)
				.WithTagAndPeriod(tag, $"top-askers/{period}")
				.GetApiUrl();

			var response = _httpClient.GetAsync(url).Result.ReadAsJsonAsync<Data<TagScore>>().ValidateApiResponse();
			return response;
		}

		BaseResponse<TagWiki> ITags.GetTagWiki(List<string> tags)
		{
			throw new System.NotImplementedException();
		}
	}
}
