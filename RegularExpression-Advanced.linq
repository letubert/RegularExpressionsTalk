<Query Kind="Program">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each reagion separately
//

void Main()
{
	// Replace MM/dd/yyyy with dd MMMM yyyy
	var text = @"The most famous unicorn was born on 2/29/2017.
The least famous unicorn was born on 103/02/20 this unicorn is still waiting to be named.
Second most famous unicorn was born a day before most famous unicorn was born. 
The second most famous unicorn was born in 2/28/2017.
A regular ordinary snow-white colored non-famous unicorn was born on 02/23/16.";

	//// Region Begin
	//// replace valid dates only 
	//// 		from:	MM/dd/yyyy 
	////		to:   	dd MMMM yyyy.  
	////	Where month may be 1 or 2 digits, day may be 1 or 2 digits and 
	////	year may be 2 or 4 digits.
	//
	//// Each Match m in the following MatchEvaluator delegate is checked for date validity
	//var res = validDateRe.Replace(text, m => {
	//	var rc = DateTime.TryParse(m.ToString(), out DateTime resultingDateTime);
	//	if (!rc) return m.ToString();
	//	
	//	var fmt = (m.Groups["year"].Value.Length == 2) ? "dd MMMM yy" : "dd MMMM yyyy";
	//	return resultingDateTime.ToString(fmt);
	//});
	//Console.WriteLine(res);
	//Console.WriteLine();
	//// Region End

	//// Region Begin
	//// How will you match only dates valid?
	//var allDates = GetAllDates(text);
	//foreach (var d in allDates)
	//	Console.WriteLine(d);
	//// Region End
}

// Define other methods and classes here

const string ValidDatePattern = @"\b(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2}|\d{4})\b";
// Q. What will happen if we take off the trailing "\b"?  Why???
// A. The year will always be a 2 digit year.  Without the trailing word boundary
//    @"\b" we will need to flip the 2 digit and 4 digit qualifiers making the
//    year group be: (?<year>\d{4}|\d{2}).  However without the trailing word
//    word boundary a date like "11/21/19880" will matched as "11/21/1988"
//const string ValidDatePattern = @"(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2}|\d{4})";
static Regex validDateRe = new Regex(ValidDatePattern);

IEnumerable<string> GetAllDates(string text)
{
	var ms = validDateRe.Matches(text);
	foreach (Match m in ms)
	{
		// The _ is a Discard available as of C# 7.0. Prior to 7.0 the _ will be a variable in its own right.
		var isValid = DateTime.TryParse(m.ToString(), out DateTime _);
		if (isValid)
			yield return m.ToString();
	}
}
//