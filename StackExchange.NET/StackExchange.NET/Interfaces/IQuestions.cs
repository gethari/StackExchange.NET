using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	/// <summary>
	/// The Questions interface which lists all possible operations.
	/// </summary>
	public interface IQuestions
	{
		/// <summary>
		///   <para>Gets all the questions on the site.</para>
		/// </summary>
		/// <param name="filters">The Question filters.</param>
		/// <returns></returns>
		BaseResponse<Question> GetAllQuestions(QuestionFilters filters);
		/// <summary>
		/// Returns the questions identified in {ids}.
		/// 
		/// This is most useful for fetching fresh data when maintaining a cache of question ids, or polling for changes.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetQuestionsByIds(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Gets the answers to a set of questions identified in id.
		/// 
		/// This method is most useful if you have a set of interesting questions, and you wish to obtain all of their answers at once or if you are polling for new or updates answers (in conjunction with sort=activity).
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Answer> GetAnswersByQuestionIds(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Gets the comments on a question.
		/// 
		/// If you know that you have an question id and need the comments, use this method. If you know you have a answer id, use GetAnswersWithIds. If you are unsure, use GetPostsWithIds.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Comment> GetCommentsByQuestionIds(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Gets questions which link to those questions identified in {ids}.
		/// 
		/// This method only considers questions that are linked within a site, and will never return questions from another Stack Exchange site.
		/// 
		/// A question is considered "linked" when it explicitly includes a hyperlink to another question. There are no other heuristics.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetLinkedQuestions(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Returns questions that the site considers related to those identified in {ids}.
		/// 
		/// The algorithm for determining if questions are related is not documented, and subject to change at any time. Furthermore, these values are very heavily cached, and may not update immediately after a question has been editted. It is also not guaranteed that a question will be considered related to any number (even non-zero) of questions, and a consumer should be able to handle a variable number of returned questions.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetRelatedQuestions(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Returns a subset of the events that have happened to the questions identified in id.
		/// 
		/// This provides data similar to that found on a question's timeline page.
		/// 
		/// Voting data is scrubbed to deter inferencing of voter identity.
		/// </summary>
		/// <param name="ids"></param>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetTimeLine(List<string> ids, QuestionFilters filters);
		/// <summary>
		/// Returns all the questions with active bounties in the system.
		/// 
		/// The sorts accepted by this method operate on the following fields of the question object:
		/// </summary>
		/// <param name="filters"></param>
		/// <returns></returns>
		BaseResponse<Question> GetFeaturedQuestions(QuestionFilters filters);
		/// <summary>
		/// Returns questions which have received no answers.
		/// 
		/// Compare with /questions/unanswered which merely returns questions that the sites consider insufficiently well answered.
		/// </summary>
		/// <returns></returns>
		BaseResponse<Question> GetQuestionsWithNoAnswers(QuestionFilters filters);
		/// <summary>
		/// Returns questions the site considers to be unanswered.
		/// 
		/// Note that just because a question has an answer, that does not mean it is considered answered. While the rules are subject to change, at this time a question must have at least one upvoted answer to be considered answered.
		/// </summary>
		/// <returns></returns>
		BaseResponse<Question> GetUnansweredQuestions(QuestionFilters filters);
	}
}
