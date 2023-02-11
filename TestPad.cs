using System;
using System.Text.RegularExpressions;

class TestPad
{
	static void Main()
	{
		string line = "9 5 3 2";
		string pattern = @"\w+";
		foreach(Match match in Regex.Matches(line, pattern))
		{
			Console.WriteLine("{0} {1}", match.Value, match.Index);
		}		
	}
}