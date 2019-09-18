using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Badges interface which lists all possible operations.
	/// </summary>
	public interface IBadges
	{
		/// <summary>
		/// Returns all the badges in the system.
		/// </summary>
		/// <param name="filters"></param>
		/// <param name="inName"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetAllBadges(BadgeFilters filters, string inName = null);
		/// <summary>
		/// Gets the badges identified in id.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetBadgesByIds(List<string> ids, BadgeFilters filters);
		/// <summary>
		/// Gets all explicitly named badges in the system.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetNonTaggedBadges(List<string> ids, BadgeFilters filters);
		/// <summary>
		/// Returns recently awarded badges in the system.
		/// </summary>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetRecentlyAwardedBadges(BadgeFilters filters);
		/// <summary>
		/// Returns recently awarded badges in the system, constrained to a certain set of badges.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetRecentlyAwardedBadgesByIds(List<string> ids, BadgeFilters filters);
		/// <summary>
		/// Returns the badges that are awarded for participation in specific tags.
		/// </summary>
		/// <param name="filters"></param>
		/// <param name="inName"></param>
		/// <returns></returns>
		BaseResponse<Badge> GetAllTaggedBadges(BadgeFilters filters, string inName = null);
	}
}
