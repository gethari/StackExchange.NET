using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IComments
	{
		BaseResponse<Comment> GetAllComments(CommentFilter commentFilter);
		BaseResponse<Comment> GetCommentsByIds(List<string> commentIds, CommentFilter commentFilter);
	}
}
