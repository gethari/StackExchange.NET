using System.Collections.Generic;
using StackExchange.NET.Models;

namespace StackExchange.NET.Interfaces
{
	interface IQuestions
	{
		BaseResponse<Question> GetAllQuestions(QuestionFilters filters);
		BaseResponse<Question> GetQuestionsByIds(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetAnswersByQuestionIds(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetCommentsByQuestionIds(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetLinkedQuestions(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetRelatedQuestions(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetTimeLine(List<string> ids, QuestionFilters filters);
		BaseResponse<Question> GetFeaturedQuestions(QuestionFilters filters);
		BaseResponse<Question> GetQuestionsWithNoAnswers();
		BaseResponse<Question> GetUnansweredQuestions();
	}
}
