using System;
using System.Collections.Generic;
using RegularExpression.TemplateReplace.Strategy;


namespace RegularExpression.TemplateReplace
{
	class Program
	{
		static void Main(string[] args)
		{
			var text = DownStreamTemplate.InputTemplate();

			// These values are hard coded here for example.  In real life they will come for somewhere else,
			// a calculation, a service or some other source.
			var heroineName = "Alice";
			var whereValue = "Wonderland";
			var whenValue = new Dictionary<int, string> { { 1, "1865" }, { 2, "26 November 1865" } };

			// Following the strategy pattern initialize the context
			// The values for the ProcessXXX(..) constructs can possibly be obtained from a service...
			//
			// The context, ctx, "knows" how to replace the tags with the appropriate value in the text.
			// The "text" in our example is the Alice in Wonderland paragraph
			// The tags are: "{Heroin}", "{Where}", "{When|1}"/"{When|2}"
			//
			// Each tag is handled by its own class
			var ctx = new List<IProcessTag> {
				new ProcessHeroine(heroineName),
				new ProcessWhere(whereValue),
				new ProcessWhen(whenValue)
			};

			// The StrategyEval facilitates the tag hydration with values
			var se = new StrategyEval(ctx);

			try
			{
				// The replacement of tags with values is done here
				var result = se.EvaluateTags(text);

				Console.WriteLine(result);
				Console.WriteLine();

				if (result == DownStreamTemplate.OriginalText())
					Console.WriteLine("*****   Resulting text equals to the original");
				else
					Console.WriteLine($"Not good {new string('*', 50)}");
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}

			Console.WriteLine();
			Console.ReadKey();
		}
	}
}
