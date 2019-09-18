using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Comments interface which lists all possible operations.
	/// </summary>
	public interface IComments
	{
		/// <summary>
		/// Gets all the comments on the site
		/// </summary>
		/// <param name="commentFilter"></param>
		/// <returns></returns>
		BaseResponse<Comment> GetAllComments(CommentFilter commentFilter);
		/// <summary>
		/// Gets the comments identified in id.
		/// </summary>
		/// <param name="commentIds"></param>
		/// <param name="commentFilter"></param>
		/// <returns></returns>
		BaseResponse<Comment> GetCommentsByIds(List<string> commentIds, CommentFilter commentFilter);
	}
}
