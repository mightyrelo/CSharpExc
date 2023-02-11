using System;

class Chapter3
{
	static void Main()
	{
		/*int number = 1234;
		int[] nums2 = new int[4];
		int sum = 0;
		Console.Write("original order: ");
		for(int i = 0; i <= nums2.Length-1; i++)
		{
			nums2[i] = ((int)(number/Math.Pow(10,nums2.Length-1-i)))%10;
			sum += nums2[i];
			Console.Write("{0} ", nums2[i]);		
		}
		Console.WriteLine("\nsum = {0} ", sum);
		Console.Write("in reverse: ");
		for(int i = nums2.Length-1; i >= 0; i--)
		{
			Console.Write("{0} ", nums2[i]);	
		}
		Console.Write("\nswap first with last: ");
		int temp = nums2[0];

		nums2[0] = nums2[nums2.Length-1];
		nums2[nums2.Length - 1] = temp;
		
		for(int i = 0; i <= nums2.Length-1; i++)
		{
			Console.Write("{0} ", nums2[i]);	
		}
		Console.Write("\nswap second with third: ");
		temp = nums2[1];
		nums2[1] = nums2[nums2.Length-2];
		nums2[nums2.Length-2] = temp;
		for(int i = 0; i <= nums2.Length-1; i++)
		{
			Console.Write("{0} ", nums2[i]);	
		}*/
		//read n v and p
		Console.Write("n: ");
		int n = int.Parse(Console.ReadLine());
		Console.Write("p: ");
		int p = int.Parse(Console.ReadLine());
		Console.Write("v: ");
		int v = int.Parse(Console.ReadLine());
		//convert dec to bin
		int q = n;
		int pos = 0;
		int[] bin = new int[8];
		while(q != 0)
		{
			bin[bin.Length - 1 - pos] = q%2;
			q = q/2;
			pos++;
		}
				
		//find bit a position p
		//Console.WriteLine("bit at pos {0} = {1} ", p, bin[bin.Length - 1 -p]);
		//is bit at pos p 1?
		//Console.WriteLine((bin[bin.Length - 1 -p] == 1) ? true : false);
		//replace bit at p with v
		bin[bin.Length - 1 - p] = v;
		//conver binary to decimal
		int newN = 0;
		for(int i = 0; i < bin.Length; i++)
		{
			newN += (int)(Math.Pow(2, bin.Length - 1 - i))*(bin[i]);	
		}
		Console.WriteLine("n: {0} ",newN);
		//is prime
			Console.Write("n: ");
			int nu = int.Parse(Console.ReadLine()); 		

			bool isPrime = true;	
			//run to n which is i
			for(int j = 2; j < nu; j++)
			{	
				if(nu%j == 0)
				{
					isPrime = false;
				}	
			}
			Console.WriteLine(isPrime ? "is prime" : "is not prime");					
	}
}