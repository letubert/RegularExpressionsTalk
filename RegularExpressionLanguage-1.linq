<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each region sepately
//

//// Region Begin
//// Match \w
//var pattern = @"\w";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// Match \d
//var pattern = @"\d";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"{m}");	// The $"{m}" is a short hand notation to string.Format("{0}", m)
////							// When m is not a primitive type then string.Format will employ
////							// m.ToString().
//// Region End


//// Region Begin
//// Match \s
//// We report the count of the number of white space characters found
//var pattern = @"\s";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//Console.WriteLine($"{ms.Count}");
//// Region End


//// Region Begin
//// Match \b
//var pattern = @"\b\w\b";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// Match \W
//var pattern = @"\W";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// Match \D
//var pattern = @"\D";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// Match \S
//var pattern = @"\S";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// Match \B
//var pattern = @"\B\d";
//var text = " ;\ta.12 ,";
//var re = new Regex(pattern);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End


//// Region Begin
//// Match .
//// When you count the characters remember to add 2 for CRLF (Carriage Return Line Feed) for each new-line
//var pattern = @"........";					// 8 period characters
////var pattern = @"................";			// 16 period characters
//var text = @"a.;'!1@#$ABcd
//123
//do-re-me";
//var re = new Regex(pattern, RegexOptions.Multiline);
////var re = new Regex(pattern, RegexOptions.Singleline);
//var ms = re.Matches(text);
//foreach (Match m in ms)
//	Console.WriteLine($"\"{m}\"");
//// Region End
//