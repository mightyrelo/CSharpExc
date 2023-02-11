using System;
using System.IO;

class Chapter11
{
	static void Main()
	{
		try
		{
			string fileName = "MyFiles.txt";
			ReadFile(fileName);
		}
		catch(IOException e)
		{
			throw new ApplicationException("Something, somewhere has gone wrong.", e);
		}
	}

	static void ReadFile(string path)
	{
		TextReader reader = null; 
		try
		{
			reader = new StreamReader(path);
			string line = reader.ReadLine();
			Console.WriteLine(line);
			
		}
		catch(FileNotFoundException)
		{
			Console.WriteLine("File '{0}' not found.", path);
		}
		finally
		{
			if(reader != null)
			{	
				reader.Close();
				Console.WriteLine("file closed");
			}	
		}	
	} 
}
