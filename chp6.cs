using System;

class Chapter6
{
	static void Main()
	{
		//dec2bin
		/*for(int k = 0; k <= 10; k++)
		{
			int[] bin = new int[8];
			int q = k;
			int c = 0;
			do
			{
				bin[bin.Length - c - 1] = q%2;
				q /= 2;
				c++;
			}
			while(q != 0);
			foreach(int bit in bin)
			{
				Console.Write("{0} ", bit);
			}
			//bin2dec
			Console.WriteLine("");
			int num = 0;
			for(int i = bin.Length -1; i >= 0; i--)
			{	
				if(bin[i] != 0)
				{	
					num += (int)Math.Pow(2,bin.Length - 1 - i);
				}	
			}
			Console.WriteLine((num == k) ? "Conversion Passed" : " Conversion Failed");
	
		}
		//dec2hex
		string[] digits = new string[2];
		//Console.Write("n: ");
		//int n = int.Parse(Console.ReadLine());
		for(int j = 0; j <= 100; j++)
		{
			int c = 0;
			int q = j;
			do
			{
				int r = q%16;	
				if(r > 9)
				{
					switch(r)
					{
						case 10:
							digits[digits.Length - c - 1] = "A";
							break;
						case 11:
							digits[digits.Length - c - 1] = "B";
							break;
						case 12:
							digits[digits.Length - c - 1] = "C";
							break;
						case 13:
							digits[digits.Length - c - 1] = "D";
							break;
						case 14:
							digits[digits.Length - c - 1] = "E";
							break;
						case 15:
							digits[digits.Length - c - 1] = "F";
							break;
						default:
							Console.WriteLine("Mathematically impossible");
							break;

					}
				}
				else
				{
					digits[digits.Length - 1 - c] = r.ToString();
				}
				q /= 16;
				c++; 
			}
			while(q != 0);
			Console.Write("{0} => 0x", j);
			for(int i = 0; i < digits.Length; i++)
			{
				Console.Write("{0}", digits[i]);
			}
			Console.WriteLine("");				
		}
		//hex2bin
		int num = 0;
		string[] hex = {"A", "B"};
		for(int i = 0; i < hex.Length; i++)
		{
			int intValue;
			bool parsed = Int32.TryParse(hex[i], out intValue);
			if(parsed)
			{
				num += intValue*(int)(Math.Pow(16, hex.Length - 1 - i));
			}
			else
			{
				switch(hex[i])
				{
					case "A":
						intValue = 10;
						break;
					case "B":
						intValue = 11;
						break;
					case "C":
						intValue = 12;
						break;
					case "D":
						intValue = 13;
						break;
					case "E":
						intValue = 14;
						break;
					case "F":
						intValue = 15;
						break;
					default:
						Console.WriteLine("not possible");
						break;
				}
				num += intValue*(int)(Math.Pow(16, hex.Length - 1 - i));
			}			

		}
		Console.WriteLine("num = {0}", num);*/
		///print in random order
		Console.Write("N: ");
		int n = int.Parse(Console.ReadLine());
		int[] nums = new int[n];
		for(int i = 0; i < nums.Length; i++)
		{
			Console.Write("num: ");
			int num = int.Parse(Console.ReadLine());			
		}
		Random rand = new Random();
		int[] existing = new int[10];
		for(int i = 0; i < nums.Length; i++)
		{
			int pos = rand.Next(nums.Length);
			Console.Write("{0} ", nums[pos]);		
		}
		

		
	}
}