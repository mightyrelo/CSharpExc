using System;

class Chapter7
{
	static void Main()
	{
		//sumUp(1.5m, 2m, 8.7m);
		//decimal[] nums = {1.7m, 2m, 8.7m};
		//sumUp();
		//max(b:9, a:7);
		
		for(int k = 3; k < 7; k++)
		{	
			printTriangle(k);		
		}
		
	}
	
	static void printRow(int start, int end)
	{
		for(int i = start; i <= end; i++)
		{
			Console.Write("{0} ", i);
		}
		Console.WriteLine("");
	}
	static void printTriangle(int n)
	{
		for(int line = 1; line <= n; line++)
			{
				printRow(1, line);
			}
		//print lower part
		for(int line = (n-1); line > 0; line--)
			{
				printRow(1,line);
			}
			Console.WriteLine("");
	}
	
	static void sumUp(params decimal[] nums)
	{
		decimal sum = 0;
		foreach(decimal num in nums)
		{
			sum += num;	
		}
		Console.WriteLine("sum = {0}", sum);
	}
	static void max(int a, int b)
	{
		Console.WriteLine((a>b)?a:b);	
	}
}