using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Posts interface which lists all possible operations.
	/// </summary>
	public interface IPosts
	{
		/// <summary>
		/// Fetches all posts (questions and answers) on the site.
		/// </summary>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Post> GetAllPosts(PostFilter filter);
		/// <summary>
		/// Fetches a set of posts by ids.
		/// 
		/// This method is meant for grabbing an object when unsure whether an id identifies a question or an answer. This is most common with user entered data.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="postFilter"></param>
		/// <returns></returns>
		BaseResponse<Post> GetAllPostsByIds(List<string> ids, PostFilter postFilter);
		/// <summary>
		/// Gets the comments on the posts identified in ids, regardless of the type of the posts.
		/// 
		/// This method is meant for cases when you are unsure of the type of the post id provided. Generally, this would be due to obtaining the post id directly from a user.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Post> GetCommentsOnPosts(List<string> ids, PostFilter filter);
		/// <summary>
		/// Returns edit revisions for the posts identified in ids.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Post> GetRevisionsByIds(List<string> ids, PostFilter filter);
		/// <summary>
		/// Returns suggested edits on the posts identified in ids.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filter"></param>
		/// <returns></returns>
		BaseResponse<Post> GetSuggestedEdits(List<string> ids, SuggestedEditFilter filter);
	}
}
