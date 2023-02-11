using System;
using System.IO;


//here the application is connected to a file on one end and to a console window
//on the other end.
class Chapter15
{
	static void Main()
	{
		/*string endpoint = "myFile.txt";
		//string endpoint2 = @"C:/Users/Lenovo/myFile2.txt";
		//string endpoint3 = "C://Users/Lenovo/myFile2.txt";
		//open file
		StreamReader reader = new StreamReader(endpoint);
		using(reader)
		{
			//use file
			string line = reader.ReadLine();
			int lineNumber = 0;
			while(line != null)
			{
				lineNumber++;
				Console.WriteLine("Line {0}: {1}", lineNumber, line);
				line = reader.ReadLine();
			}
		}*/
		/*string path = "Numbers.txt";
		StreamWriter writer = new StreamWriter(path, true);
		using(writer)
		{
			for(int i = 1; i <=20; i++)
			{
				writer.WriteLine(i);
			}
		}*/
		string path = @"C:/Users/Lenovo/Documents/myFile2.txt";
		try
		{
			StreamReader reader = new StreamReader(path);
			Console.WriteLine("File opened successfully, reading...");
			using(reader)
			{
				Console.WriteLine(reader.ReadToEnd());
			}
		}
		catch(FileNotFoundException)
		{
			Console.Error.WriteLine("Cannot find file {0}", path);
		}
		catch(DirectoryNotFoundException)
		{
			Console.Error.WriteLine("Invalid directory in the file path.");
		}
		catch(IOException)
		{
			Console.Error.WriteLine("Could not open file {0}", path);
		}	
	}	
}