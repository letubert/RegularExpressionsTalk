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
giving the story lasting popularity with adults as well as with children.[2] It is
considered to be one of the best examples of the literary nonsense genre.[2][3] Its
narrative course and structure, characters and imagery have been enormously influential[3]
in both popular culture and literature, especially in the fantasy genre.";

//// Region Begin
//// [character_group]
//var pattern = @"1[89]\d\d";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"{m}");
//
//// Will the above pattern match 119888?  Add it to the text and see...
//// Region End


//// Region Begin
//// [^character_group]
//var pattern = @"\b[^aei][^aei][^aei][^aei][^aei][^aei][^aei]\b";		// 7 consecutive [^aei]
//var re = new Regex(pattern, RegexOptions.Singleline);
//var m = re.Match(text);
//Console.WriteLine($"{m}");
//// Region End


//// Region Begin
//// ^
//var pattern = @"^\w\w\w\w\w";                                   // 5 /w
//var re = new Regex(pattern, RegexOptions.Multiline);
////var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"{m}");
//// Region End


//// Region Begin
//// $
//// This is an example where the "\r" in the pattern is mandatory
//var pattern = @"\w+\r$";
//var re = new Regex(pattern, RegexOptions.Multiline);
////var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"{m}");
//// Region End


//// Region Begin
//// |
//var pattern = @"good|better|best";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"{m}");
//// Region End


//// Region Begin
//// ()
//const string pattern = @"(((\w+)\s)+)(Wonderland)";
//var re = new Regex(pattern, RegexOptions.Singleline);
//var m = re.Match(text);
//Console.WriteLine($" m.Success:  {m.Success}");
//Console.WriteLine($"m.ToString:  \"{m}\"");
//Console.WriteLine($"   Group-0:  \"{m.Groups[0].Value}\"");
//Console.WriteLine($"   Group-1:  \"{m.Groups[1].Value}\"");
//Console.WriteLine($"   Group-2:  \"{m.Groups[2].Value}\"");
//Console.WriteLine($"   Group-3:  \"{m.Groups[3].Value}\"");
//Console.WriteLine($"   Group-4:  \"{m.Groups[4].Value}\"");
//// Region End


//// Region Begin
//// Date
//const string pattern = @"\b(0?[1-9]|1[0-2])/(0?[1-9]|[1-2]\d|3[0-1])/(19|20)\d\d\b";
//var re = new Regex(pattern);
//var textDate = @"4/31/2018 is not a real date but matches the rules above 
//05/31/2018 is a valid date
//2/31/1772 has a year that is not in our range while 02/31/1972 has a year that is in range
//21/12/1999 has a month, 21, that is out of range for the month
//12345/29/2018000 both month and year do not follow the digit count before/after the boundary
//13/29/2018 has a month that is out of range
//12/32/2018 has a day that is out of range";
//var ms = re.Matches(textDate);
//foreach (Match m in ms)
//	m.ToString().Dump();
//// Region End
//