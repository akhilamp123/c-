// accept a flight fare and booking time //

Console.WriteLine("enter flight fares");
double fare = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("enter the booking time");
double time = Convert.ToDouble(Console.ReadLine());
if (time >= 6 && time <= 9)
{
    fare = fare + (fare * 0.1);
    Console.WriteLine(fare);

}
if (time >= 9 && time <= 17)
{
    fare = fare + (fare * 0.2);
    Console.WriteLine(fare);
}
if (time >= 17 && time <= 23)
{
    fare = fare + (fare * 0.07);
    Console.WriteLine(fare);
}
if (time >= 23 && time <= 6)
{
    fare = fare + (fare * 0.05);
    Console.WriteLine(fare);
}


