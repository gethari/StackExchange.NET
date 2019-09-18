#region Using Directives

using System;
using System.Collections.Generic;
using System.Linq;
using NSubstitute;
using NUnit.Framework;
using StackExchange.NET.Clients;
using StackExchange.NET.Interfaces;
using StackExchange.NET.Models;

#endregion

namespace Tests
{
	public class AnswerClientTests
	{
		private BaseResponse<Answer> _baseResponse;
		private IAnswers _answers;
		private AnswerFilters _answerFilters;
		private StackExchangeClient _client;
		[SetUp]
		public void Setup()
		{
			_baseResponse = Substitute.For<BaseResponse<Answer>>();
			_answers = Substitute.For<IAnswers>();
			_answerFilters = Substitute.For<AnswerFilters>();
			_client = Substitute.For<StackExchangeClient>("someKey");
		}

		[Test]
		public void GetAllAnswers()
		{
			_answers.GetAllAnswers(_answerFilters).Returns(_baseResponse);
		}

		[Test]
		public void GetAllAnswersWithNullFilter()
		{
			Assert.Throws<ArgumentNullException>(() => _client.Answers.GetAllAnswers(null));
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
			Assert.Throws<ArgumentNullException>(() => _client.Answers.GetAnswerByIds(null, _answerFilters));
		}
	}
}