using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IAnswers
	{
		BaseResponse<Answer> GetAllAnswers(AnswerFilters filters);
		BaseResponse<Answer> GetAnswerByIds(List<string> ids, AnswerFilters filters);
		BaseResponse<Answer> GetCommentsByIds(List<string> ids, AnswerFilters filters);
		BaseResponse<Question> GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters);
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
