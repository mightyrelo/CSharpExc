using System;

class Test
{
	static void Main()
	{
		int num = 7;
		int n = num;
		double fact = 1;
		while(true)
		{
			if(n<=1)
			{
				break;
			}
			fact *= n;
			n--;	
		}
		Console.WriteLine("{0}! = {1}", num, fact);
		
	}	
}