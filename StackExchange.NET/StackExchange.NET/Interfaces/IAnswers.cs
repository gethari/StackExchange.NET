using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Answers interface which lists all possible operations.
	/// </summary>
	public interface IAnswers
	{
		/// <summary>Returns all the undeleted answers in the system.</summary>
		/// <param name="filters">The Answer filters.</param>
		/// <returns>This method returns a list of answers</returns>
		BaseResponse<Answer> GetAllAnswers(AnswerFilters filters);
		/// <summary>
		/// Gets the set of answers identified by ids.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Answer> GetAnswerByIds(List<string> ids, AnswerFilters filters);
		/// <summary>
		/// Gets the comments on a set of answers.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Answer> GetCommentsOnAnswers(List<string> ids, AnswerFilters filters);
		/// <summary>
		/// Returns the questions that answers identified by {ids} are on.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetQuestionByAnswerIds(List<string> ids, AnswerFilters filters);
		//void AcceptAnAnswer(string id, AnswerFilters filters);
		//void UndoAcceptedAnswer(string id, AnswerFilters filters);
		//void DeleteAnswer(string id, AnswerFilters filters);
		//void DownVoteAnswer(string id, AnswerFilters filters);
		//void UndoDownVotedAnswer(string id, AnswerFilters filters);
		//void EditAnswer(string id, AnswerFilters filters);
		//void GetOptionsOfAnswer(string id, AnswerFilters filters);
		//void FlagAnswer(string id, AnswerFilters filters);
		//void UpVoteAnswer(string id, AnswerFilters filters);
		//void UndoUpVotedAnswer(string id, AnswerFilters filters);
	}
}
