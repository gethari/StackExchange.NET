using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IComments
	{
		BaseResponse<Comments> GetAllComments(CommentFilter commentFilter);
		BaseResponse<Comments> GetCommentsByIds(List<string> commentIds, CommentFilter commentFilter);
	}
}
