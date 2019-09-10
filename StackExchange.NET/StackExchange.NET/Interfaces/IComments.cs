using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IComments
	{
		Comments GetAllComments(CommentFilter commentFilter);
		Comments GetCommentsByIds(List<string> commentIds, CommentFilter commentFilter);
	}
}
