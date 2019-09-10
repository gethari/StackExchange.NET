using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IBadges
	{
		Badges GetAllBadges(BadgeFilters filters, string inName = null);
		Badges GetBadgesByIds(List<string> ids, BadgeFilters filters);
		Badges GetNonTaggedBadges(List<string> ids, BadgeFilters filters);
		Badges GetRecentlyAwardedBadges(BadgeFilters filters);
		Badges GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters);
		Badges GetAllTaggedBadges(BadgeFilters filters, string inName = null);
	}
}
