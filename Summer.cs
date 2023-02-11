using System;


class GenerateMessage
{
	private static Random rand = new Random();

	private static string[] phrases = {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
	private static string[] stories = new string[]{"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
	private static string[] names = new string[]{"Dayan", "Stella", "Hellen", "Kate"};
	private static string[] surnames = new string[]{"Johnson", "Peterson", "Charls"};
	private static string[] cities = new string[]{"London", "Paris", "Berlin", "New York", "Madrid"};	
	

	public static string GenerateRandomMessage()
	{
		//select random phrase
		string phrase = "";
		string story = "";
		string name = "";
		string surname = "";
		string city = "";
		for(int i = 0; i < phrases.Length; i++)
		{
			phrase = phrases[rand.Next(phrases.Length)];	
		}
		//select random story
		for(int i = 0; i < stories.Length; i++)
		{
			story = stories[rand.Next(stories.Length)];	
		}
		//select random last name
		for(int i = 0; i < names.Length; i++)
		{
			name = names[rand.Next(names.Length)];	
		}
		//random surname
		for(int i = 0; i < surnames.Length; i++)
		{
			surname = surnames[rand.Next(surnames.Length)];	
		}
		//random city
		for(int i = 0; i < cities.Length; i++)
		{
			city = cities[rand.Next(cities.Length)];	
		}
		string message = phrase + " " + story + "--" + name + " " + surname + ", " + city;
		return message;
	}

	static void Main()
	{
		/*Console.Write("Enter sequence: ");
		string seq = Console.ReadLine();
		string[] elements = seq.Split(' ');
		int sum = 0;
		foreach(string el in elements)
		{
			sum += int.Parse(el);	
		}
		Console.WriteLine("-> {0}", sum);*/
		for(int i = 0; i < 5; i++)
		{
			Console.WriteLine(GenerateRandomMessage());
		}
				
		
	}
}