using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
	
	static void Main()
	{
		//read file into array
		string fileName = @"../SquareMatrix.txt";
		string[] input = MaximalComputer.ReadFileIntoArray(fileName);
		//parse size
		int size = int.Parse(input[0]); 
		//parse matrix
		int[,] sqMatrix = new int[size, size];
		sqMatrix = MaximalComputer.ParseElements(input, size);
		//compute maximal sum
		MaxElements maximalEls = MaximalComputer.ComputeMaximalSum(sqMatrix);
		//write sum to file
		MaximalComputer.WriteSumToFile(maximalEls, sqMatrix);
	}
}

class MaxElements
{
	public int MaxSum
	{
		get;set;
	}
	public int BestRow
	{
		get;set;
	}
	public int BestCol
	{
		get;set;
	}
	public MaxElements(int maxSum, int bestRow, int bestCol)
	{
		this.MaxSum = maxSum;
		this.BestRow = bestRow;
		this.BestCol = bestCol;
	}
}

class MaximalComputer
{
			
	public static string[] ReadFileIntoArray(string path)
	{
		try
		{
			string[] input = File.ReadAllLines(path);
			return input;
		}
		catch(FileNotFoundException)
		{
			Console.Error.WriteLine("file not found");
		}
		catch(IOException)
		{
			Console.Error.WriteLine("Error while reading");
		}
		return null;
		
	}
	
	public static int[,] ParseElements(string[] lines, int size)
	{
		string[] matrix = RemoveFirstLine(lines);
		int[,] numberMatrix = new int[size, size];
		int lineNumber = 0;
		foreach(string line in matrix)
		{
			string pattern = @"\w+";
			int count = 0;
			foreach(Match match in Regex.Matches(line, pattern))
			{
				numberMatrix[lineNumber,count] = int.Parse(match.Value);
				count++;		
			}
			lineNumber++;
	
		}
		return numberMatrix;
	}
	
	private static string[] RemoveFirstLine(string[] lines)
	{
		string[] matrix = new string[lines.Length - 1];
		for(int i = 1; i < lines.Length; i++)
		{
			matrix[i-1] = lines[i];
		}
		return matrix;
	}
	
	public static void WriteSumToFile(MaxElements maxEls, int[,] matrix)
	{
		try
		{
			StreamWriter writer = new StreamWriter("output.txt");
			using(writer)
			{
				writer.WriteLine("Maximal sum of Square Matrix is {0}.", maxEls.MaxSum);
				writer.WriteLine("Maximal Square Matrix: ");
				writer.WriteLine("{0} {1}", matrix[maxEls.BestRow, maxEls.BestCol], matrix[maxEls.BestRow, maxEls.BestCol+1]);
				writer.WriteLine("{0} {1}", matrix[maxEls.BestRow+1, maxEls.BestCol], matrix[maxEls.BestRow+1, maxEls.BestCol+1]);
				
			}
		}
		catch(IOException)
		{
			Console.Error.WriteLine("error while writing");
		}
	}
	
	public static MaxElements ComputeMaximalSum(int[,] matrix)
	{
		int maxSum = int.MinValue;
		int bestRow = 0;
		int bestCol = 0;
		MaxElements maxEls = new MaxElements(maxSum, bestRow, bestCol);
		for(int row = 0; row < matrix.GetLength(0)-1; row++)
		{
			for(int col=0; col < matrix.GetLength(1)-1; col++)
			{
				int curSum = matrix[row,col] + matrix[row,col+1] + matrix[row+1,col] + matrix[row+1,col+1];
				if(curSum > maxSum)
				{
					maxEls.MaxSum = curSum;
					maxEls.BestRow = row;
					maxEls.BestCol = col;
				}
			}
		}
		return maxEls;
	}
	
}