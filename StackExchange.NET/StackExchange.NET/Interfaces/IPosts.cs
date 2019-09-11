using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IPosts
	{
		BaseResponse<Posts> GetAllPosts(PostFilter filter);
		BaseResponse<Posts> GetAllPostsByIds(List<string> ids, PostFilter postFilter);
		BaseResponse<Posts> GetCommentsOnPosts(List<string> ids, PostFilter filter);
		BaseResponse<Posts> GetRevisionsByIds(List<string> ids, PostFilter filter);
		BaseResponse<Posts> GetSuggestedEdits(List<string> ids, SuggestedEditFilter filter);
	}
}
