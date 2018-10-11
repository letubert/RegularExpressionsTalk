
namespace RegularExpression.TemplateReplace
{
	public static class DownStreamTemplate
	{
		// From Alice in Wonderland
		// {Heroine}
		// {Where}
		// {When|1}
		// {When|2}
		public static string InputTemplate()
		{
			var inputStream = @"{Heroine}'s Adventures in {Where}
From Wikipedia, the free encyclopedia
""{Heroine} in {Where}"" redirects here. For other uses, see {Heroine} in {Where} (disambiguation).
{Heroine}'s Adventures in {Where}
{Heroine} in {Where}, cover {When|1}.jpg
Cover of the original edition ({When|1})
Author	Lewis Carroll
Illustrator	John Tenniel
Country	United Kingdom
Language	English
Genre	Fiction
Publisher	Macmillan
Publication date
{When|2}
Followed by	Through the Looking-Glass
{Heroine}'s Adventures in {Where} (commonly shortened to {Heroine} in {Where}) is an {When|1} novel written by English author 
Charles Lutwidge Dodgson under the pseudonym Lewis Carroll.[1] It tells of a girl named {Heroine} falling through a rabbit 
hole into a fantasy world populated by peculiar, anthropomorphic creatures. 
The tale plays with logic, giving the story lasting popularity with adults as well as with children.[2] 
It is considered to be one of the best examples of the literary nonsense genre.[2][3] Its narrative course and structure, 
characters and imagery have been enormously influential[3] in both popular culture and literature, especially in the fantasy genre.";

			return inputStream;
		}

		public static string OriginalText()
		{
			var originalText = @"Alice's Adventures in Wonderland
From Wikipedia, the free encyclopedia
""Alice in Wonderland"" redirects here. For other uses, see Alice in Wonderland (disambiguation).
Alice's Adventures in Wonderland
Alice in Wonderland, cover 1865.jpg
Cover of the original edition (1865)
Author	Lewis Carroll
Illustrator	John Tenniel
Country	United Kingdom
Language	English
Genre	Fiction
Publisher	Macmillan
Publication date
26 November 1865
Followed by	Through the Looking-Glass
Alice's Adventures in Wonderland (commonly shortened to Alice in Wonderland) is an 1865 novel written by English author 
Charles Lutwidge Dodgson under the pseudonym Lewis Carroll.[1] It tells of a girl named Alice falling through a rabbit 
hole into a fantasy world populated by peculiar, anthropomorphic creatures. 
The tale plays with logic, giving the story lasting popularity with adults as well as with children.[2] 
It is considered to be one of the best examples of the literary nonsense genre.[2][3] Its narrative course and structure, 
characters and imagery have been enormously influential[3] in both popular culture and literature, especially in the fantasy genre.";

			return originalText;
		}
	}
}
