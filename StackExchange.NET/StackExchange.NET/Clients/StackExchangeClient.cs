using System;
using System.Net;
using System.Net.Http;

namespace StackExchange.NET.Clients
{
	public partial class StackExchangeClient
	{
		private readonly string _baseApiUrl;
		private readonly HttpClient _httpClient;
		private readonly string _apiKey;

		public StackExchangeClient(string apiKey)
		{
			if (string.IsNullOrWhiteSpace(apiKey))
			{
				throw new Exception($"Api Key cannot be null or empty : {nameof(apiKey)}");
			}
			_apiKey = apiKey;
			_baseApiUrl = $"https://api.stackexchange.com/2.2";
			var httpClientHandler = new HttpClientHandler()
			{
				AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
			};
			_httpClient = new HttpClient(httpClientHandler);
		}
	}
}