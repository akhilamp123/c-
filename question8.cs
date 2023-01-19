// 8. accept the flight fare in decimal into an array.accept the destination into another array. accept the nth number from keyboard and desplay destination and fare

Console.WriteLine("Enter the flight fare:");
decimal[] fare = new decimal[3];
for (int i = 0;i < fare.Length; i++)
{
    fare[i] = Convert.ToDecimal(Console.ReadLine());
}

Console.WriteLine("Enter the destinations:");
string[] dest = new string[3];
for(int i = 0;i < dest.Length; i++)
{
    dest[i] = Console.ReadLine();
}

Console.WriteLine("Enter the nth number:");
int n = Convert.ToInt32(Console.ReadLine());

if( n < fare.Length )
{
    Console.WriteLine(fare[n]);
    Console.WriteLine(dest[n]);
}
else
{
    Console.WriteLine("Result not found");
}