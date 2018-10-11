<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each region separately
//

var text = @"This is 	 text with   far  too   much   
whitespace.
1	2	3";
//var text = "This is \t text with   far  too   much   \nwhitespace.\n1	2	3";

//// Region Begin
//// Replace a string of white space characters with a single space, 
//// Regular expression options: Multiline and Singleline
//const string pattern = @"\s+"; 
//// If you wish to preserve line integrity then do not include it in the pattern...
//// @"\s" will match both CR (Carriage Return, '\r') and LF (Line Feed, '\n').  
//// Therefore the new pattern will be @"[ \t]+"
////const string pattern = @"[ \t]+";
//string replacement = " ";
////var re = new Regex(pattern, RegexOptions.Multiline);		// Multiline or Singleline will make no difference
//var re = new Regex(pattern, RegexOptions.Singleline);			// since "\s" will match "\r" and "\n" 
//var result = re.Replace(text, replacement);
//Console.WriteLine(result);
//// Region End


//// Region Begin
////Replace the first 3 string of white space characters with a single space
//const string pattern = @"\s+";
//string replacement = " ";
//var re = new Regex(pattern);
//var result = re.Replace(text, replacement, 3);		// Replace 3 of the pattern matches only
//Console.WriteLine(result);
//// Region End


//// Region Begin
//// Replace a string of white space characters with a single space
//// using the regular expression *static* Replace method
//const string pattern = @"\s+";
//string replacement = " ";
//var result = Regex.Replace(text, pattern, replacement);
//Console.WriteLine(result);
//// Region End


//// Region Begin
//// Replace a string of white space characters with a single space
//// using the static Replace method and regular expression options: IgnoreCase and Singleline
//// As we discovered previously RegexOptions.Singleline and RegexOptions.Multiline are immaterial
//// Since \s matches CR ('\r') and LF ('\n') characters.  Obviously RegexOptions.IgnoreCase is
//// superflous since WS (whitespace) is neither upper-case nor lower-case.
//const string pattern = @"\s+";
//string replacement = " ";
//var result = Regex.Replace(text, pattern, replacement, RegexOptions.IgnoreCase | RegexOptions.Singleline);
//Console.WriteLine(result);
//// Region End


//// Region Begin
//// Replace a string of white space characters with a single space using the MatchEvaluator delegate
//// If the Match contains LF ('\n') character then replace it with a 3 space string otherwise replace
//// the match with a single space.
//const string pattern = @"\s+";
//var re = new Regex(pattern);
//var result = re.Replace(text, m => m.ToString().Contains("\n") ? "   " : " ");
//Console.WriteLine(result);
//// Region End


//// Region Begin
//// Replace a string of white space characters with a single space using the MatchEvaluator delegate
//// Using the static Replace method
//const string pattern = @"\s+";
//var result = Regex.Replace(text, pattern, m => " ");
//Console.WriteLine(result);
//// Region End


//// Region begin
//// Replace the whole search-pattern:
//// 	Add an astrisk (*) prefix and a minus (-) suffix to the search-pattern
//// The pattern, @"[^a-z]+", is any sequential other than lower-case letters
//// The text: "Hello World".  So the pattern will match: "H" and " W" and the
//// Replace will replace "H" with "*H-" and " W" with "* W-"
//var pattern = @"[^a-z]+";
//var text2 = "Hello World";
//var re = new Regex(pattern);
//var res = re.Replace(text2, "*$0-");
//Console.WriteLine($"Pattern  = [^a-z].                 Result: {res}");
//// Region end


//// Region begin
//// $n
//// The pattern: @"\b(\w+)(\s)(\w+)\b" has 3 groups of interest:
//// Group 1: "\w+" is the first word
//// Group 2: "\s"  is a space between the first and second word
//// Group 3: "\w+" is the second word
//// The replaced text: "$3$2$1" which switches the first and second words
//// So "One two three" becomds "two One three"
//var pattern2 = @"\b(\w+)(\s)(\w+)\b";
//var text2 = "One two three";
//var re2 = new Regex(pattern2);
//var res2 = re2.Replace(text2, @"$3$2$1");
//Console.WriteLine($"Pattern2 = \\b(\\w+)(\\s)(\\w+)\\b.       Result: {res2}");
////
//// What happens when we repace $4 a group that does not exists
//// In which case the RE evaluator assumes that you mean "$4"
//var res3 = re2.Replace(text2, @"$3$2$1$4");		// What is $4
//Console.WriteLine($"Same pattern2 but no match for $4.   Result: {res3}");
//var res4 = re2.Replace(text2, @"$3$2$1$$4");     // For clarity use $$4
//Console.WriteLine($"$$ is a better specification of $.   Result: {res4}");
//// Region end


//// Region begin
//// Advanced
//// Same as pattern2 but with named groups
//var pattern5 = @"\b(?<firstWord>\w+)(?<singleSpace>\s)(?<secondWord>\w+)\b";
//var text5 = "One two three";
//var re5 = new Regex(pattern5);
//var res5 = re5.Replace(text5, @"${secondWord}${singleSpace}${firstWord}");
//Console.WriteLine($"Same as pattern2 but w names.      Result: {res5}");
////  Re2 has no named groups.  When we attempt to replace named groups RE evaluator
////	assumes that we mean ${name}
//var re2 = new Regex(@"\b(\w+)(\s)(\w+)\b");
//var res2 = re2.Replace(text5, @"${secondWord}${singleSpace}${firstWord}");
//Console.WriteLine($"Same as pattern2 but w names.      Result: {res2}");
//// Re5 named groups can also be accessed as sequential numbered groups
//var res52 = re5.Replace(text5, @"$3$2$1");
//Console.WriteLine($"Pattern5 but replace w $3$2$1:     Result: {res52}");
//// Region end


//// Region Begin
//// Advanced
//// Named groups means that you need not count parentheses...
//const string patM = @"(?<month>0?[0-9]|1[0-2])";
//const string patD = @"(?<day>0?[1-9]|[12]\d|3[01])";
//const string patY = @"(?<year>(19|20)\d{2})";
//var pattern = $@"\b{patM}/{patD}/{patY}\b";
//const string text6 = "The date 11/21/1988 was a good day";
//var re = new Regex(pattern);
//var m = re.Match(text6);
//if (m.Success)
//	Console.WriteLine(m.Groups["month"].Value);       // 11
//
//var res = re.Replace(text6, @"${year}-${month}-${day}");
//Console.WriteLine(res);								// Replace "11/21/1988" with "1988-11-21"
//// Region End


//// Region Begin
//// Gotcha
//// Unnamed groups are indexed first, named groups follow
//const string pattern = @"(?<NamedGroup1>a)(b)(?<NamedGroup2>c)(d)";
//const string textGotchar = "blah abcd blah";
//var re = new Regex(pattern);
//var m = re.Match(textGotchar);
//if (!m.Success) return;
//for (var i = 0; i < m.Groups.Count; ++i)
//{
//	var gr = m.Groups[i];
//	Console.WriteLine($"Index: {i}.  Value: {gr.Value}");
//}
//