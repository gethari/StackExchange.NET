using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface ISuggestedEdits
	{
		/// <summary>
		/// Returns all the suggested edits in the systems.
		/// </summary>
		/// <returns></returns>
		BaseResponse<SuggestedEdits> GetAllSuggestedEdits(SuggestedEditFilter filters);
		/// <summary>
		/// Returns suggested edits identified in ids.
		/// 
		/// {ids} can contain up to 100 semicolon delimited ids. To find ids programmatically look for suggested_edit_id on suggested_edit objects.
		/// </summary>
		/// <returns></returns>
		BaseResponse<SuggestedEdits> GetSuggestedEditsByIds(List<string> ids,SuggestedEditFilter filters);
	}
}
