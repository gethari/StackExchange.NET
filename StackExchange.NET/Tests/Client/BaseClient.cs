using NSubstitute;
using NUnit.Framework;
using StackExchange.NET.Clients;

namespace Tests.Client
{
	public class BaseClient
	{
		internal StackExchangeClient Client;
		[SetUp]
		public void Setup()
		{
			Client = Substitute.For<StackExchangeClient>("someKey");
		}
	}
}
