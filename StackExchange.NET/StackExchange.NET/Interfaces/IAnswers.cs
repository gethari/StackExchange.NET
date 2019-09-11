using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	public interface IAnswers
	{
		BaseResponse<Answers> GetAllAnswers(AnswerFilters filters);
		BaseResponse<Answers> GetAnswerByIds(List<string> ids, AnswerFilters filters);
		BaseResponse<Answers> GetCommentsByIds(List<string> ids, AnswerFilters filters);
		BaseResponse<Questions> GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters);
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
