#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace Tests.Client
{
	public class AnswerClient : BaseClient
	{
		private readonly BaseResponse<Answer> _baseResponse;
		private readonly IAnswers _answers;
		private readonly AnswerFilters _answerFilters;

		public AnswerClient()
		{
			_baseResponse = Substitute.For<BaseResponse<Answer>>();
			_answers = Substitute.For<IAnswers>();
			_answerFilters = Substitute.For<AnswerFilters>();
		}

		[Test]
		public void GetAllAnswers()
		{
			_answers.GetAllAnswers(_answerFilters).Returns(_baseResponse);
		}

		[Test]
		public void GetAllAnswersWithNullFilter()
		{
			Assert.Throws<ArgumentNullException>(() => Client.Answers.GetAllAnswers(null));
		}

		[Test]
		public void GetAnswerByIds()
		{
			var ids = Substitute.For<ICollection<string>>();
			_answers.GetAnswerByIds(ids.ToList(), _answerFilters).Returns(_baseResponse);
		}

		[Test]
		public void GetAnswerByIdsWithNull()
		{
			Assert.Throws<ArgumentNullException>(() => Client.Answers.GetAnswerByIds(null, _answerFilters));
		}

		[Test]
		public void GetCommentsOnAnswers()
		{
			var ids = Substitute.For<ICollection<string>>();
			_answers.GetCommentsOnAnswers(ids.ToList(), _answerFilters).Returns(_baseResponse);
		}
	}
}