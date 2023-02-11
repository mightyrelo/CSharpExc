using System;
using System.Text.RegularExpressions;

class Regexc
{
	static void Main()
	{
		/*string text = "katlego.gagoopane@accsight.org only email replaced.";
		string expr = "[A-Za-z.]+@\\w+\\.\\w+";
		Console.WriteLine(Regex.Replace(text, expr, "**"));
		string text = "This is a sentence that contains Softuni."
		+"this sentence contains Poftuni.This one has CoftUni";
		string expr = "[A-Z]oft[Uu]ni";
		Console.WriteLine(Regex.Replace(text, expr, "***"));
		string text = "this is a rand!om 2 text used to illustrate a point";
		string exp = "\\w";
		Console.WriteLine(Regex.Replace(text, exp, "****"));
		string text = "softuni is a [great] place"
		+ "softuni is a [bad] place" + "softuni is a [] place";
		string exp = "softuni is a \\[\\w*\\] place";
		Console.WriteLine(Regex.Replace(text, exp, "*"));
		string text = "katlego.gagoopane@accsight.org only email replaced."
		+"katlego@accsight.co.uk";
		string expr = "\\w+\\.?\\w+@\\w+\\.\\w+\\.?\\w+";
		Console.WriteLine(Regex.Replace(text, expr, "**"));
		string text = "katlego\tenoch\ngagoopane";
		string exc = "[\\t\\n]";
		Console.WriteLine(Regex.Replace(text, exc, "**" ));
		string text = "some random words that don't mean anything else.";
		string exc = "anything$";
		Console.WriteLine(Regex.Replace(text, exc, "*"));
		string text = "+2778909715";
		string exc = "\\+\\d{11}$";
		Console.WriteLine(Regex.Replace(text, exc, "**"));*/
		string text = "peter is peter and that is it."
		+"george is george and that is it.";
		string exp = "(\\w+) is \\1 and that is it.";
		Console.WriteLine(Regex.Replace(text, exp, "*"));
	
	}
	
}