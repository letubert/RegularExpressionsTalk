using System.Text.RegularExpressions;

namespace RegularExpression.TemplateReplace.Strategy
{
	public class ProcessWhere : IProcessTag
	{
		/// <summary>Tag to be replaced with a value</summary>
		private const string Pattern = @"{Where}";

		/// <summary>Regex that will facilitate the change of the tag with the value of Where</summary>
		private static readonly Regex ProcessRegex = new Regex(Pattern);

		/// <summary>A place holder, storing the values of {Where}</summary>
		private readonly string _where;

		/// <summary>
		/// The constructor is the mechanism for passing in the value set of the When to this class, so the tag
		/// will be replaced with the appropriate place holder value.
		/// </summary>
		/// <param name="where"></param>
		public ProcessWhere(string where) => _where = where;

		#region Implementation of IProcess

		public string HydrateTag(string text) => ProcessRegex.Replace(text, _where);

		#endregion
	}
}
