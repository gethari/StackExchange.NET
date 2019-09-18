using System;

namespace StackExchange.NET.Exceptions
{
	/// <summary>
	/// StackExchangeApiException
	/// </summary>
	public class StackExchangeApiException : Exception
	{
		/// <summary>
		/// Create a new StackExchangeApiException
		/// </summary>
		public StackExchangeApiException(long errorId, string errorName, string errorMessage)
			: base($"{errorName} - {errorId}: {errorMessage}")
		{
			ErrorId = errorId;
			ErrorName = errorName;
			ErrorMessage = errorMessage;
		}

		/// <summary>
		/// error_id
		/// </summary>
		public readonly long ErrorId;

		/// <summary>
		/// error_name
		/// </summary>
		public readonly string ErrorName;

		/// <summary>
		/// error_message
		/// </summary>
		public readonly string ErrorMessage;
	}
}
