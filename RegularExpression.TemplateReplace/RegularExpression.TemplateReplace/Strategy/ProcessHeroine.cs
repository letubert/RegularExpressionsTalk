using System.Text.RegularExpressions;

namespace RegularExpression.TemplateReplace.Strategy
{
	/// <summary>
	/// {Heroine}
	/// </summary>
	public class ProcessHeroine : IProcessTag
	{
		/// <summary>Tag to be replaced with a value</summary>
		private const string Pattern = @"{Heroine}";

		/// <summary>Regex that will facilitate the change of the tag with the value of the Heroine</summary>
		private static readonly Regex ProcessRegex = new Regex(Pattern);

		/// <summary>A place holder, storing the value of the Heroine</summary>
		private readonly string _heroineName;

		/// <summary>
		/// The constructor is the mechanism for passing in the value of the Heroine to this class, to be stored
		/// in the _heroineName place holder, so the tag will be replaced with the value in the place holder.
		/// </summary>
		/// <param name="heroineName"></param>
		public ProcessHeroine(string heroineName) => _heroineName = heroineName;

		#region Implementation of IProcess

		public string HydrateTag(string text)
		{
			var result = ProcessRegex.Replace(text, _heroineName);
			return result;
		}

		#endregion
	}
}
