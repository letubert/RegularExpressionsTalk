<Query Kind="Statements">
  <Output>DataGrids</Output>
</Query>

//
// Readme
// This is an example that is not part of the talk
//
// We demonstrate a few of the syntax essentials
// 1.	New up Regex once
// 2.	Demonstrate the difference between group identifying with parentheses and matching parentheses
//   	When matching parentheses we need to escape the parentheses
// 3.	Matching the inside of parentheses
//

//
// Demonstrates Match.Success on text
// When we match parentheses we escape the parentheses
// This pattern, @"\((.*)\)", contains only 1 group
const string pat = @"\((.*)\)";
var re = new Regex(pat, RegexOptions.IgnoreCase | RegexOptions.Singleline);
var text = @"abc";
var m = re.Match(text);
Console.WriteLine($"1.  {m.Success}");		// We expect m.Success to be false

// Without re-newing the Regex (re) we can process text2
var text2 = @"(abc)";
var m2 = re.Match(text2);
Console.WriteLine($"2.  {m2.Success}");

// Processing text3, @"((abc) def)", with the Regex we newed up earlier display Match.Success as true
// and Group[1].Value as: "(abc) def".  .* is greedy.
var text3 = @"((abc) def)";
var m3 = re.Match(text3);
Console.WriteLine($"3.  {m3.Success},  {m3.Groups[1].Value}");

// pat4 is the similar to the previous pat but uses lazy asterisk.
// This time evaluating text4, @"((abc) def)", yields "(abc" for group[1].Value.
const string pat4 = @"\((.*?)\)";
var re4 = new Regex(pat4, RegexOptions.IgnoreCase | RegexOptions.Singleline);
var text4 = @"((abc) def)";
var m4 = re4.Match(text4);
Console.WriteLine($"4.  {m4.Success},  {m4.Groups[1].Value}");

// pat5 is matching anything between an open parenthesis and close parenthesis that contains no parenthesis
const string pat5 = @"\(([^()]*)\)";
var re5 = new Regex(pat5, RegexOptions.IgnoreCase | RegexOptions.Singleline);
var text5 = @"((abc) def)";
var m5 = re5.Match(text5);
Console.WriteLine($"5.  {m5.Success},  {m5.Groups[1].Value}");
//