using System;

class Chapter7
{
	static void PrintArray(int[] arr)
	{
		foreach(int el in arr)
		{
			Console.Write("{0} ", el);
		}
	}
	static bool GreaterThanNeighbours(int pos, int[] arr)
	{
		if(pos < arr.Length - 1 && pos >= 1)
		{
			return (arr[pos] > arr[pos+1]) && (arr[pos] > arr[pos-1]);
		}
		return false;
	}
	static int FirstOccurenceOfGreater(int[] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			if(GreaterThanNeighbours(i, arr))
			{
				return i;
			}
		}
		return -1;	
	}
	
	static int[] SplitNumber(int num)
	{
		int[] digits = new int[3];
		for(int digit = 0; digit < digits.Length; digit++)
		{	
			int curDigit = ((num/((int)Math.Pow(10, digits.Length - 1 - digit))))%10;
			digits[digit] = curDigit;
		}

		return digits;
	}
	static int[] ReverseArray(int[] arr)
	{
		int[] rArr = new int[arr.Length];
		for(int i = 0; i < arr.Length; i++)
		{
			rArr[arr.Length - 1 - i] = arr[i];	
		}
		return rArr;
	}
	
	static int FindPosOfMax(int start, int[] arr)
	{
		int max = arr[start];
		int maxPos = start;
		for(int i = start; i < arr.Length; i++)
		{
			if(arr[i] > max)
			{
				max = arr[i];
				maxPos = i;
			}	
		}
		return maxPos;
	}

	static void Swap(int pos1, int pos2, int[] arr)
	{
		int temp = arr[pos1];
		arr[pos1] = arr[pos2];
		arr[pos2] = temp;
	}
	
	static int[] SortInDescendingOrder(int[] arr)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			int start = i;
			int maxPos = FindPosOfMax(start, arr);
			Swap(maxPos, i, arr);
		}
		return arr;
	}
	
	static int[] ReverseDigits(int num)
	{
		if(num >  1 && num < 50000000)
		{
			int[] digits = SplitNumber(num);
			return ReverseArray(digits);
		}
		return null;
		 
	}

	static double CalculateAverage(params int[] numbers)
	{
		if(numbers.Length > 0)
		{
			int sum = 0;
			foreach(int number in numbers)
			{
				sum += number;
			}
			return (double)sum/numbers.Length;
		}
		return 0;
		
	}
	static double SolveEquation(int a, int b)
	{
		if(a != 0)
		{
			double x = -(double)b/a;
			return x;
		}
		return 0;
	
	}
	
	static void DoReverseOrder()
	{
		Console.Write("num: ");
		int num = int.Parse(Console.ReadLine());
		PrintArray(ReverseDigits(num));
	}

	static void DoCalculateAverage()
	{
		Console.Write("terms: ");
		int n = int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		int k = 0;
		do
		{
			Console.Write("number: ");
			arr[k] = int.Parse(Console.ReadLine());
			k++; 	
		}
		while(k <= n);
		Console.WriteLine("average is {0}", CalculateAverage(arr));
	}

	static void DoSolveEquation()
	{
		Console.Write("a: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("b: ");
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine(SolveEquation(a, b));
	}

	static int[] CalculateSumOfPolys(int[] poly1, int[] poly2)
	{
		int[] sum = new int[3];
		for(int i = 0; i < sum.Length; i++)
		{
			sum[i] = poly1[i] + poly2[i];
		}
		return sum;	
	}

	static void Main()
	{	/*
		//int[] arr = new int[]{2,2,3,4,5,1};
		//Console.WriteLine(GreaterThanNeighbours(1,arr));
		//Console.WriteLine(FirstOccurenceOfGreater(arr));
		//split
		Console.Write("num: ");
		int num = int.Parse(Console.ReadLine());
		int[] number = SplitNumber(num);
		//reverse
		int[] rArr = ReverseArray(number);
		//print
		PrintArray(rArr);
		int[] numbers = new int[]{23, 2, 4, 7, 11, 8, 19, 6, 12, 1, 5};
		PrintArray(SortInDescendingOrder(numbers));
		Console.Write("Pick a Task(0,1,2): ");
		int task = int.Parse(Console.ReadLine());
		switch(task)
		{
			case 0:
				DoReverseOrder();
				break;
			case 1:
				DoCalculateAverage();
				break;
			case 2: 
				DoSolveEquation();
				break;
			default:
				Console.WriteLine("wrong choice");
				break;
		}*/
		int[] poly1 = new int[]{1, 2, -3};
		int[] poly2 = new int[]{2, 8, 14};
		PrintArray(CalculateSumOfPolys(poly1, poly2));
	}
	
}