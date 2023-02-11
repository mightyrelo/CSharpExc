using System;

class Chapter11
{
	static void Main()
	{
		//read date from user
		Console.Write("Year (YYYY): ");
		int year = int.Parse(Console.ReadLine());
		Console.Write("Month (MM): ");
		int month = int.Parse(Console.ReadLine());
		Console.Write("Day (dd): ");
		int day = int.Parse(Console.ReadLine());

		//create DateTime object from input
		DateTime dueDate = new DateTime(year, month, day);
	
		//calculate work days in interval
		int totalDays = CalculateTotalDays(dueDate);
		int daysWithoutWeekends = DiscardWeekends(totalDays);
		int workDays = CalculateOfficialWorkDays(dueDate);
		

		//display results
		Console.WriteLine("Between {0:dd/MM/yyyy} and {1:dd/MM/yyyy}", DateTime.Now, dueDate);
		Console.WriteLine("There are {0} days in total. ", totalDays);
		Console.WriteLine("Of those {0} are work days. ", daysWithoutWeekends);
		Console.WriteLine("And only {0} are official work days. ", workDays); 
	}

	

	public static int CalculateOfficialWorkDays(DateTime dueDate)
	{
		int interval = CalculateTotalDays(dueDate);
		int workDays = DiscardWeekends(interval);
		int officialWorkDays = DiscardHolidays(interval, workDays);
		return officialWorkDays;
	}

	public static int CalculateTotalDays(DateTime dueDate)
	{
		int dueDay = ConvertDateToDay(dueDate);
		int today = ConvertDateToDay(DateTime.Now);
		int interval = dueDay - today;
		if(interval > 0)
		{
			return interval;
		}
		return (365 - interval);
	}

	private static int ConvertDateToDay(DateTime date)
	{
		return date.DayOfYear;
	}		

	public static int DiscardWeekends(int interval)
	{
		//collect all Date objects into an array
		DateTime[] dates = new DateTime[interval];
		DateTime today = DateTime.Now;
		for(int i = 0; i < dates.Length; i++)
		{
			dates[i] = today.AddDays(i);
		}
		//count worksday only in array
		int workDays = 0;
		for(int i = 0; i < dates.Length; i++)
		{
			if(!IsWeekendDay(dates[i]))
			{
				workDays++;
			}
		}
		return workDays;
	}

	private static bool IsWeekendDay(DateTime date)
	{
		if(date.DayOfWeek.ToString() == "Saturday" || date.DayOfWeek.ToString() == "Sunday")
		{
			return true;
		}
		return false;
	}


	private static int DiscardHolidays(int interval, int workDays)
	{
		int totalDays = workDays;
		//collect all Date objects into an array
		DateTime[] dates = new DateTime[interval];
		DateTime today = DateTime.Now;
		for(int i = 0; i < dates.Length; i++)
		{
			dates[i] = today.AddDays(i);
		}
		//remove work days from count
		for(int i = 0; i < dates.Length; i++)
		{
			if(IsHoliday(dates[i]))
			{
				totalDays--;
			}
		}
		return totalDays;
					
	}	
	
	private static bool IsHoliday(DateTime date)
	{
		DateTime[] holidays = new DateTime[18];
		holidays[0] = new DateTime(2023, 3, 21);
		holidays[1] = new DateTime(2023, 4, 7);
		holidays[2] = new DateTime(2023, 4, 8);
		holidays[3] = new DateTime(2023, 4, 9);
		holidays[4] = new DateTime(2023, 4, 10);
		holidays[5] = new DateTime(2023, 4, 27);
		holidays[6] = new DateTime(2023, 5, 1);
		holidays[7] = new DateTime(2023, 5, 14);
		holidays[8] = new DateTime(2023, 6, 16);
		holidays[9] = new DateTime(2023, 8, 9);
		holidays[10] = new DateTime(2023, 9, 24);
		holidays[11] = new DateTime(2023, 9, 25);
		holidays[12] = new DateTime(2023, 12, 16);
		holidays[13] = new DateTime(2023, 12, 24);
		holidays[14] = new DateTime(2023, 12, 24);
		holidays[15] = new DateTime(2023, 12, 25);
		holidays[16] = new DateTime(2023, 12, 26);
		holidays[17] = new DateTime(2023, 12, 31);
		for(int i = 0; i < holidays.Length; i++)
		{
			if(ConvertDateToDay(date) == ConvertDateToDay(holidays[i]))
			{
				return true;
			}
		}
		return false;
	}

}

