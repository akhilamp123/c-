

//// 4. accept the passenger dob

Console.WriteLine("enter the passenger dob as (dd/mm/yyy):");
DateTime presentTime = DateTime.Now;
DateTime dt = Convert.ToDateTime(Console.ReadLine());

// display age in hours
TimeSpan lifetime = DateTime.Now - dt;
double hours = lifetime.TotalHours;
Console.WriteLine(Convert.ToInt32(hours) + " hours.");

//display age in days
double days = lifetime.Days;
Console.WriteLine(Convert.ToInt32(days) + " days.");

//display age in weeks
double weeks = days / 7;
Console.WriteLine(Convert.ToInt32(weeks) + " weeks.");

// display age in months
double months = days / 30;
Console.WriteLine(Convert.ToInt32(months) + " months.");

//display age in years
double years = days / 365;
Console.WriteLine(Convert.ToInt32(years) + " years.");

// display whether the year of birth is leap year or not
if (dt.Year % 4 == 0)
{
    Console.WriteLine("You were born in a leapyear.");
}
else
{
    Console.WriteLine("You were not born in a leap year.");
}




