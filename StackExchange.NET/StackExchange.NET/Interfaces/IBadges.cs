using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IBadges
	{
		BaseResponse<Badges> GetAllBadges(BadgeFilters filters, string inName = null);
		BaseResponse<Badges> GetBadgesByIds(List<string> ids, BadgeFilters filters);
		BaseResponse<Badges> GetNonTaggedBadges(List<string> ids, BadgeFilters filters);
		BaseResponse<Badges> GetRecentlyAwardedBadges(BadgeFilters filters);
		BaseResponse<Badges> GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters);
		BaseResponse<Badges> GetAllTaggedBadges(BadgeFilters filters, string inName = null);
	}
}
