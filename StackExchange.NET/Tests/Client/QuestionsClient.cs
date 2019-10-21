using System;
using NSubstitute;
using NUnit.Framework;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

namespace Tests.Client
{
	class QuestionsClient : BaseClient
	{
		private readonly BaseResponse<Question> _baseResponse;
		private readonly IQuestions _questions;
		private readonly QuestionFilters _questionFilters;
		
		public QuestionsClient()
		{
			_baseResponse = Substitute.For<BaseResponse<Question>>();
			_questions = Substitute.For<IQuestions>();
			_questionFilters = Substitute.For<QuestionFilters>();
		}

		[Test]
		public void GetAllQuestions()
		{
			_questions.GetAllQuestions(_questionFilters).Returns(_baseResponse);
		}

		[Test]
		public void GetAllQuestionsWithNullFilter()
		{
			Assert.Throws<ArgumentNullException>(() => Client.Questions.GetAllQuestions(null));
		}
	}
}
