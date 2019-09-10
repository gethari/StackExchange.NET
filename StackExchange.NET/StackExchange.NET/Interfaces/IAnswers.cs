using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IAnswers
	{
		Answers GetAllAnswers(AnswerFilters filters);
		Answers GetAnswerByIds(List<string> ids, AnswerFilters filters);
		Answers GetCommentsByIds(List<string> ids, AnswerFilters filters);
		Questions GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters);
		void AcceptAnAnswer(string id, AnswerFilters filters);
		void UndoAcceptedAnswer(string id, AnswerFilters filters);
		void DeleteAnswer(string id, AnswerFilters filters);
		void DownVoteAnswer(string id, AnswerFilters filters);
		void UndoDownVotedAnswer(string id, AnswerFilters filters);
		void EditAnswer(string id, AnswerFilters filters);
		void GetOptionsOfAnswer(string id, AnswerFilters filters);
		void FlagAnswer(string id, AnswerFilters filters);
		void UpVoteAnswer(string id, AnswerFilters filters);
		void UndoUpVotedAnswer(string id, AnswerFilters filters);
	}
}
