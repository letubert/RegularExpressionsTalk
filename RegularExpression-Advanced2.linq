<Query Kind="Expression">
  <Output>DataGrids</Output>
</Query>

//
//	Read me
//	Run each region separately
//

//// Region Begin
//// Match C# compound statements that may be nested
//// We are looking for compound statement {..}
//// In the following example we see 2 compound statements the one is for the if conditional and one is
//// for the for loop.
//var text = @"for (var i = 0; i < 10; ++i)
//{
//	if (i % 2 == 0)
//	{
//		Console.WriteLine($""i is even"");
//	}
//}";
//// Does not work
//var pattern = @"\{.*?\}";			// Since "{" and "}" are not used as a count then they do not require escaping.
////var pattern = @"{.*?}";
//// Works
////var pattern = @"\{[^{}]*\}";		// The lazy evaluation of "[^{}]*?" is not needed since we are looking for
////var pattern = @"{[^{}]*}";			// all the non-"{" or "}" between the "{" and "}"
//var re = new Regex(pattern, RegexOptions.Singleline);
//var m = re.Match(text);
//if (m.Success)
//	Console.WriteLine(m.ToString());
//// Region End


//// Region Begin
//// How will you match nested pattern like Pascal’s compound statement “begin..end”
//var text = @"for i := 1 to 10 do
//begin
//    if i mod 2 = 0 then
//	begin
//		WriteLn(""%D is even"", i)
//	end
//end";
//
//// Replace "begin" with '\u0001' and
//// replace "end" with '\u0002'
//// Replace the "begin" and "end" with RE.Replace in order to avoid constructs like "beginning" --
//// this is not our issue here but I included it here as a more complete example.
//// An even better example would be to have the massaged texts as static values of instace Regex classes.
//var t1 = Regex.Replace(text, @"\bbegin\b", '\u0001'.ToString(), RegexOptions.IgnoreCase);
//var t2 = Regex.Replace(t1, @"\bend\b", '\u0002'.ToString(), RegexOptions.IgnoreCase);
//
//var pattern = $@"\u0001[^\u0001\u0002]*\u0002";
//var re = new Regex(pattern);
//var m = re.Match(t2);
//if (m.Success)
//	// We replace '\u0001' with "begin" and '\u0002' with "end" in case that one of the
//	// "begin" / "end" are not matched.
//	Console.WriteLine(m.ToString().Replace('\u0001'.ToString(), "begin").Replace('\u0002'.ToString(), "end"));
//// Region End
//