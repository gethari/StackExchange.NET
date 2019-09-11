using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IPosts
	{
		BaseResponse<Post> GetAllPosts(PostFilter filter);
		BaseResponse<Post> GetAllPostsByIds(List<string> ids, PostFilter postFilter);
		BaseResponse<Post> GetCommentsOnPosts(List<string> ids, PostFilter filter);
		BaseResponse<Post> GetRevisionsByIds(List<string> ids, PostFilter filter);
		BaseResponse<Post> GetSuggestedEdits(List<string> ids, SuggestedEditFilter filter);
	}
}
