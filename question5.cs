// 5. accept the flight fares in decimal format and put it an array at even or odd positions.

using System.Security.Cryptography;

Console.WriteLine("enter the number of flight fares");
int fare = Convert.ToInt32(Console.ReadLine());
decimal[] arr = new decimal[fare*2];

int even = 0;
int odd = 1;
Console.WriteLine("enter the elements");
for (int i = 0; i < fare; i++)
{
    decimal value = Convert.ToDecimal(Console.ReadLine());
    if (value % 2 == 0)
    {
        arr[even] = value;
        even += 2;
    }
    else
    {
        arr[odd] = value;
        odd += 2;
    }
}

foreach (var a in arr)
{
    Console.WriteLine(a);
}


