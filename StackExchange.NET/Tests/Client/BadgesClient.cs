using NSubstitute;
using NUnit.Framework;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

namespace Tests.Client
{
	public class BadgesClient : BaseClient
	{
		private readonly BaseResponse<Badge> _baseResponse;
		private readonly IBadges _badges;
		private readonly BadgeFilters _badgeFilters;

		public BadgesClient()
		{
			_baseResponse = Substitute.For<BaseResponse<Badge>>();
			_badges = Substitute.For<IBadges>();
			_badgeFilters = Substitute.For<BadgeFilters>();
		}

		[Test]
		public void GetAllBadges()
		{
			_badges.GetAllBadges(_badgeFilters).Returns(_baseResponse);
		}
	}
}
