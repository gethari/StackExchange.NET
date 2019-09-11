using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IBadges
	{
		BaseResponse<Badge> GetAllBadges(BadgeFilters filters, string inName = null);
		BaseResponse<Badge> GetBadgesByIds(List<string> ids, BadgeFilters filters);
		BaseResponse<Badge> GetNonTaggedBadges(List<string> ids, BadgeFilters filters);
		BaseResponse<Badge> GetRecentlyAwardedBadges(BadgeFilters filters);
		BaseResponse<Badge> GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters);
		BaseResponse<Badge> GetAllTaggedBadges(BadgeFilters filters, string inName = null);
	}
}
