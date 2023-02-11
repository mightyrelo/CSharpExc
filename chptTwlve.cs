using System;

class ChapterT
{
	static void Main()
	{
		/*Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		Console.WriteLine("{0:N2}" , (n>0) ? Math.Sqrt(n) : 4);
		Console.WriteLine("Goodbye!");*/
		ReadNumbers();
		
	}
	
	static void ReadNumbers()
	{
		for(int i = 0; i < 10; i++)
		{
			ReadNumber(1,100);
		}
	}
	
	static bool IsValid(int n, int start, int end)
	{
		return (n>=start) && (n<=end);	
	}

	static void ReadNumber(int start, int end)
	{
		Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		if(!IsValid(n,start,end))
		{
			throw new Exception("number outside range");
		}	
	}
}