using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace RegularExpression.TemplateReplace.Strategy
{
	public class ProcessWhen : IProcessTag
	{
		/// <summary>Tag to be replaced with a value</summary>
		private const string Pattern = @"{When\|(?<WhenSelection>[12])}";

		/// <summary>Regex that will facilitate the change of the two kinds of tag with the appropriate value of When</summary>
		private static readonly Regex ProcessRegex = new Regex(Pattern);

		/// <summary>A place holder, storing the values of both {When|1} and {When|2}</summary>
		private readonly Dictionary<int, string> _when;

		/// <summary>
		/// The constructor is the mechanism for passing in the values of the When types to this class, to be stored
		/// in the _when place holder, so the tags kinds will be replaced with the appropriate place holder value.
		/// </summary>
		/// <param name="when">A structure holding all possible When values</param>
		public ProcessWhen(Dictionary<int, string> when) => _when = when;

		#region Implementation of IProcess

		/// <summary>
		/// The constructor is the mechanism for passing in the set of values of When's to this class, to be stored
		/// in the _when place holder, so the tags will be replaced with the appropriate place holder value.
		/// </summary>
		/// <param name="text"></param>
		public string HydrateTag(string text)
		{
			var result = ProcessRegex.Replace(text, WhenEvaluator);
			return result;
		}

		#endregion

		private string WhenEvaluator(Match m)
		{
			var whenSelection = m.Groups["WhenSelection"].Value;
			var when = int.Parse(whenSelection);
			return _when[when];
		}
	}
}
