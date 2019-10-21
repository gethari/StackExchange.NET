using System.Collections.Generic;
using StackExchange.NET.Helpers;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IApiUrlHelper
	{
		ApiUrlBuilder ForClient(ClientType type, string route = "");
		ApiUrlBuilder WithFilter(Filter filter, string inName = "");
		ApiUrlBuilder WithIds(List<string> ids, string route = "");
		ApiUrlBuilder WithTagAndPeriod(string tag, string period);
	}
}
