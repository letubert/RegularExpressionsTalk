<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each region separately
//

// Text from Alice in wonderland, Wikepedia: 
// https://en.wikipedia.org/wiki/Alice%27s_Adventures_in_Wonderland
// First paragraph
var text = @"Alice's Adventures in Wonderland (commonly shortened to Alice in Wonderland) 
is an 1865 novel written by English author Charles Lutwidge Dodgson under the pseudonym 
Lewis Carroll.[1] It tells of a girl named Alice falling through a rabbit hole into a 
fantasy world populated by peculiar, anthropomorphic creatures. The tale plays with logic, 
giving the story lasting popularit of the best examples of the literary nonsense genre.[2][3] Its 
narrative course and structure, characters and imagery have y with adults as well as with children.[2] It is 
considered to be to be one of the best examples of the literary nonsense genre.[2][3] Its narrative course 
and structure, characters and imagery have been enormously influential[3] 
in both popular culture and literature, especially in the fantasy genre.";


//// Region Begin
//// *
//const string pattern = @"i\w*n";
//var re = new Regex(pattern, RegexOptions.IgnoreCase);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// +
//const string pattern = @"i\w+n";
//var re = new Regex(pattern, RegexOptions.IgnoreCase);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// ?
//const string pattern = @"i\w?s";
//var re = new Regex(pattern, RegexOptions.IgnoreCase);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// {n}
//const string pattern = @"\b\w*e{2}\w*\b";
//var re = new Regex(pattern, RegexOptions.IgnoreCase);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// {min,}
//const string pattern = @"\D\d{2,}\D";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// {min,max}
//const string pattern = @"\D\d{1,4}\D";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// *?
//// The greedy pattern @"\[.*\]"  will match the first "[" then all the characters up to and including the last "]"
//// The  lazy  pattern @"\[.*?\]" will match the "[" with the first "]"
//const string pattern = @"\[.*\]";
////const string pattern = @"\[.*?\]";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//var i = 0;
//foreach (Match m in ms)
//	// $"{m}" is short hand for string.Format("{0}", m) which will translate m to m.ToString
//	Console.WriteLine($"{i++}.  {m}");		// display match count
//// Region End


//// Region Begin
//// {1,}?
//// Note:
////		we use RegexOptions.Singleline
////		We employ re.Match
//// The greedy pattern: @".{1,}\s",  will match the first character up to (and including) the last  white space character.
//// The  lazy  pattern: @".{1,}?\s", will match the first character up to (and including) the first white space character.
////const string pattern = @".{1,}\s";
//const string pattern = @".{1,}?\s";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var m = re.Match(text);
//Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//var testPeriodBeginEnd = $"Abraham and Sarah{Environment.NewLine}Isaac and Rebecca{Environment.NewLine}Jacob and Rachel, Leah, Bilha and Zilpah";
//var pat = @"^.*$";
//
//Console.WriteLine("RegexOptions.None: pattern: \"^.*$\"");
//var reN = new Regex(pat);
//var msN = reN.Matches(testPeriodBeginEnd);
//foreach (Match m in msN)
//	Console.WriteLine(m.ToString());
//
//Console.WriteLine();
//Console.WriteLine("RegexOptions.None: patter: \"^(.|\\n)*$\"");
//var pat2 = @"^(.|\n)*$";					// [.\n] will match a period (not a wild character) or a \n
//var reN2 = new Regex(pat2);
//var msN2 = reN2.Matches(testPeriodBeginEnd);
//foreach (Match m in msN2)
//	Console.WriteLine($"\"{m}\"");
//
//Console.WriteLine();
//Console.WriteLine("RegexOptions.Singleline: pattern: \"^.*$\"");
//var reS = new Regex(pat, RegexOptions.Singleline);
//var msS = reS.Matches(testPeriodBeginEnd);
//foreach (Match m in msS)
//	Console.WriteLine($"\"{m}\"");
//
//Console.WriteLine();
//Console.WriteLine("RegexOptions.Multiline: pattern: \"^.*$\"");
//var reM = new Regex(pat, RegexOptions.Multiline);
//var msM = reM.Matches(testPeriodBeginEnd);
//foreach (Match m in msM)
//	Console.WriteLine($"\"{m}\"");
//Console.WriteLine($"{string.Join(" ", msM[0].ToString().Select(c => (int)c))}");
//// Region End
////