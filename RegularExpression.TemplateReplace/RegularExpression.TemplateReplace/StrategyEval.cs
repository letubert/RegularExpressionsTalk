using System.Collections.Generic;
using System.Linq;
using RegularExpression.TemplateReplace.Strategy;


namespace RegularExpression.TemplateReplace
{
	public class StrategyEval
	{
		private readonly List<IProcessTag> _context;

		public StrategyEval(IEnumerable<IProcessTag> context) => _context = context.ToList();

		public string EvaluateTags(string inputText)
		{
			string currentText;
			for (var prevText = inputText; ; prevText = currentText)
			{
				currentText = prevText;

				// In our case this for loop is sufficient to carry on the task of replacing the tags with the appropriate values
				// However, if the possibility exists that, for example, the tag {Heroine} will be replaced with the value "{When|1}"
				// Then we need the outer loop.
				foreach (var procEval in _context)
					currentText = procEval.HydrateTag(currentText);

				if (currentText == prevText) break;
			}

			return currentText;
		}
	}
}
