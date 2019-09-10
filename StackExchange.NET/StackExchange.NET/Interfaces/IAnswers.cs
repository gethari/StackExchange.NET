using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Answers
{
	public interface IAnswers
	{
		Models.Answers GetAllAnswers(QueryFilters filters);
		void GetAnswerById(List<string> ids, QueryFilters filters);
		void AcceptAnAnswer(string id, QueryFilters filters);
		void UndoAcceptedAnswer(string id, QueryFilters filters);
		void DeleteAnswer(string id, QueryFilters filters);
		void DownVoteAnswer(string id, QueryFilters filters);
		void UndoDownVotedAnswer(string id, QueryFilters filters);
		void EditAnswer(string id, QueryFilters filters);
		void GetOptionsOfAnswer(string id, QueryFilters filters);
		void FlagAnswer(string id, QueryFilters filters);
		void UpVoteAnswer(string id, QueryFilters filters);
		void UndoUpVotedAnswer(string id, QueryFilters filters);
	}
}
