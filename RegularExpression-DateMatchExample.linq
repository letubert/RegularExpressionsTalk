<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

class Program
{
	private const string _pat = @"\d+/\d+/\d+ (\d+:\d+(:\d+(\.\d+)?)?)?";
	private static readonly Regex _re = new Regex(_pat);

	//
	//	The example displayed in slide 11
	//	entitled: Example of date match MM/dd/yyyy HH:mm:ss.fff
	//
	static void Main()
	{
		var text1 = "The date 11/21/1988 00:23 was a good point in time";
		Match match = _re.Match(text1);
		if (match.Success)
			Console.WriteLine("Date time found");
		else
			Console.WriteLine("Date time was not found");

		var text2 = "The date 11/21/1988 00:23 was a good point in time. 01/01/2000 00:00:00.000 more text";
		MatchCollection ms = _re.Matches(text2);
		foreach (Match m in ms)
			Console.WriteLine(m.ToString());
	}
}