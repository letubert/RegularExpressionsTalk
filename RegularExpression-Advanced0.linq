<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each region separately
//

//// Region Begin
//// Evaluation happens LR (Left to Right)
//var text = "The date 11/21/1988 was a good day";
//var pattern = @"\d{1,2}/\d{1,2}/(\d{2}|\d{4})";
////var pattern = @"\d{1,2}/\d{1,2}/(\d{4}|\d{2})";
////var pattern = @"\b\d{1,2}/\d{1,2}/(\d{2}|\d{4})\b";
//var re = new Regex(pattern);
//var m = re.Match(text);
//if (m.Success)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// RegexOptions.RightToLeft
//var pattern = @"\b\w+\b";
//var text = "The big brown fox jumped over the lazy dog";
//var re = new Regex(pattern, RegexOptions.RightToLeft);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	// $"{m} " is a shorthand to string.Format("{0} ", m).  string.Format translates m to m.ToString()
//	Console.Write($"{m} ");
//// Region End
//