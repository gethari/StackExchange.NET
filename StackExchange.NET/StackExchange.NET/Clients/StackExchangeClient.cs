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
			_apiKey = apiKey;
			_baseApiUrl = $"https://api.stackexchange.com/2.2";
			var httpClientHandler = new HttpClientHandler()
			{
				AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip
			};
			_httpClient = new HttpClient(httpClientHandler);
		}

		public string ListType<T>(T value)
		{
			var valueType = value.GetType().GenericTypeArguments[0].FullName;
			return valueType;
		}
	}
}