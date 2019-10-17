using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Tags interface which lists all possible operations.
	/// </summary>
	public interface ITags
	{
		/// <summary>
		/// Returns the tags found on a site.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Tags> GetAllTags(TagFilter filter);
		/// <summary>
		/// Returns tag objects representing the tags in {tags} found on the site.
		/// </summary>
		/// <param name="tags"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Tags> GetTagsByNames(List<string> tags, TagFilter filter);
		/// <summary>
		/// Returns the tags found on a site that only moderators can use.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Tags> GetModeratorOnlyTags(TagFilter filter);
		/// <summary>
		/// Returns all tag synonyms found on the site.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<TagSynonyms> GetAllTagSynonyms(TagFilter filter);
		/// <summary>
		/// Get frequently asked questions in a set of tags.
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		BaseResponse<Question> GetFrequentlyAskedQuestions(List<string> tags);
		/// <summary>
		/// Get related tags, based on common tag pairings.
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		BaseResponse<Tags> GetRelatedTags(List<string> tags);
		/// <summary>
		/// Get the synonyms for a specific set of tags.
		/// </summary>
		/// <param name="tags"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<TagSynonyms> GetSynonymsForTags(List<string> tags, TagFilter filter);
		/// <summary>
		/// Get the top answer posters in a specific tag, either in the last month or for all time.
		/// Enter any tag for param1 and period can be all_time or month
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="period"></param>
		/// <returns></returns>
		BaseResponse<TagScore> GetTopAnswerersPosts(string tag, string period);
		/// <summary>
		/// Get the top question askers in a specific tag, either in the last month or for all time.
		/// Enter any tag for param1 and period can be all_time or month
		/// </summary>
		/// <param name="tag"></param>
		/// <param name="period"></param>
		/// <returns></returns>
		BaseResponse<TagScore> GetTopAskers(string tag, string period);
		/// <summary>
		/// Get the wiki entries for a set of tags.
		/// </summary>
		/// <param name="tags"></param>
		/// <returns></returns>
		BaseResponse<TagWiki> GetTagWiki(List<string> tags);
	}
}
