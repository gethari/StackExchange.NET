using System;
using System.Collections.Generic;
using System.Linq;

namespace StackExchange.NET.Helpers
{
	/// <summary>
	/// Used for Validating parameters for Exceptions
	/// </summary>
	public abstract class MakeSure
	{
		/// <summary>Checks an argument to make sure it isn't null</summary>
		/// <param name="value">The argument value to check</param>
		/// <param name="name">The name of the argument</param>
		/// <exception cref="ArgumentNullException"></exception>
		public static void ArgumentNotNull(object value, string name)
		{
			if (value != null)
				return;
			throw new ArgumentNullException(name);
		}

		/// <summary>
		/// Checks a string argument to ensure it isn't null or empty.
		/// </summary>
		/// <param name = "value">The argument value to check</param>
		/// <param name = "name">The name of the argument</param>
		public static void ArgumentNotNullOrEmptyString(string value, string name)
		{
			ArgumentNotNull(value, name);
			if (!string.IsNullOrWhiteSpace(value)) return;

			throw new ArgumentException("String cannot be empty", name);
		}

		public static void ArgumentNotNullOrEmptyEnumerable<T>(IEnumerable<T> value, string name)
		{
			ArgumentNotNull(value, name);
			if (value.Any()) return;

			throw new ArgumentException("List cannot be empty", name);
		}
	}
}
