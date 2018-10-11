<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
//	How will you match on “not-string".
//	To match on a character that is not “b” we will use @“[^b]”
//	How will we find a name that is not “Benjamin”
//

const string name = "Benjamin";
// Note the addition of the comma in the character group.  Without the comma excluded
// the names: Albert and Charlie will contain the trailing comma.
var pattern = $@"\b[^\u0001,]+\b";
//var pattern = @"\b\w+\b";

var text = "Albert, Benjamin, Charlie, David";
var textMassaged = text.Replace(name, '\u0001'.ToString());

var re = new Regex(pattern, RegexOptions.IgnoreCase);
var ms = re.Matches(textMassaged);
foreach (Match m in ms)
{
	var textPart = m.ToString().Replace('\u0001'.ToString(), name);
	Console.WriteLine(textPart);
}