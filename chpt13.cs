using System;
using System.Text;
using System.Text.RegularExpressions;

class Chapter13
{
	static void Main()
	{
		/*string text = "Please contact us by phone (+001 222 222 222) or by email at "
		 + "example@gmail.com or at test.user@yahoo.co.uk. This is not email: " +
		"test@test. This also: @gmail.com. Neither this: a@a.b.";	
		Console.WriteLine(ExtractEmails(text));
		string text = "I was born at 14.06.1980. My sister was born at 3.7.1984. "
		+ "In 5/1999 I graduated my high school. The law says (see section 7.3.12)"
		+ "that we are allowed to do this (section 7.4.2.9).";
		Console.WriteLine(ExtractDates(text));
		string text = "Hi my name is Young ABBA. I like racecar, I think their music"
		+"is on point. Besides that lamal sounds almost like jamal but is not quite"
		+" lamal. exe stands for executable";
		Console.WriteLine(ExtractPalindromes(text));*/
		Console.Write("text: ");
		string text = Console.ReadLine();
		string sortedLetters = SortLetters(text);
		Console.WriteLine(sortedLetters);
		CountOccurrences(sortedLetters);
			
	}
	
	static void CountOccurrences(string letters)
	{
		//get element
		int pos = 0;
		while(pos <= (letters.Length-1))
		{
			int count = 0;
			if(pos >= (letters.Length-2))
			{
				break;
			}
			while((letters[pos] == letters[pos+1]))
			{
				pos++;
				count++;
					
			}
			Console.WriteLine("\"{0}\" appears {1} times.", letters[pos], count+1);
			pos++;				
		}
		//last letter
		int counter = 1;
		while(letters[pos] == letters[pos-1])
		{
			counter++;
			pos--;			
		}
		Console.WriteLine("\"{0}\" appears {1} times.", letters[pos], counter+1);	
	}

	static string SortLetters(string text)
	{
		StringBuilder sb = new StringBuilder();
		sb.Append(text);
		for(int i = 0; i < sb.Length; i++)
		{
			int minPos = FindMinPos(sb, i);
			Swap(sb, minPos, i);
		}
		return sb.ToString();
	}
	static int FindMinPos(StringBuilder text, int start)
	{
		int min = (int)text[start];
		int minPos = start;
		for(int i = start; i < text.Length; i++)
		{
			if((int)text[i] < min)
			{
				minPos = i;
				min = (int)text[i];
			}	
		}
		return minPos;
	}
	static void Swap(StringBuilder sb, int pos1, int pos2)
	{
		char temp = sb[pos1];
		sb[pos1] = sb[pos2];
		sb[pos2] = temp;
	}

	static string ExtractPalindromes(string text)
	{
		StringBuilder sb = new StringBuilder();
		char[] separators = new char[]{' ', ',', '.'};
		string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
			foreach(string word in words)
		{
			if(word.Length > 2 && IsPalindrome(word))
			{
				sb.Append(word + " ");
			}
		}
		return sb.ToString();		
	}

	
	static string ExtractEmails(string text)
	{
		
		StringBuilder sb = new StringBuilder();
		foreach(Match match in Regex.Matches(text, "[A-Za-z.]+@[A-z]+.co[.a-z]+"))
		{
			sb.Append(match.Value);
		}
		return sb.ToString();

	}

	static string ExtractDates(string text)
	{
		StringBuilder sb = new StringBuilder();
		foreach(Match match in Regex.Matches(text, "[0-3]*[0-9].[0-2]*[0-9].[0-9]{4}"))
		{
			sb.Append(match.Value + " ");
		}
		return sb.ToString();
	}
	
	static bool IsPalindrome(string word)
	{
		for(int i = 0; i < word.Length; i++)
		{
			if(word[i] != word[word.Length - 1 - i])
			{
				return false;
			}	
		}
		return true;
	}
}