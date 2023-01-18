// accept 10 fares in decimal format into an array //


using System;

//int[] intArray = new int[10];
Console.WriteLine("enter 10  flight fares");
decimal[] decimalArray = new decimal[10];
for (int i = 0; i < decimalArray.Length; i++)
{
    decimalArray[i] = Convert.ToDecimal(Console.ReadLine());
}

// print fares in ascending order

Console.WriteLine("sort array in ascending order");
Array.Sort(decimalArray);
for (int i = 0; i < decimalArray.Length; i++)
{
    Console.WriteLine(decimalArray[i] + " ");
}

// print fares in descending order

Console.WriteLine("sort array in descending order");
Array.Reverse(decimalArray);
for (int i = 0; i < decimalArray.Length; i++)
{
    Console.WriteLine(decimalArray[i] + " ");
}

// finding the duplicate elements

Console.WriteLine("duplicate elements");
for (int i = 0; i < decimalArray.Length; i++)
{
    for (int j = i + 1; j < decimalArray.Length; j++)
    {
        if (decimalArray[i] == decimalArray[j])
            Console.WriteLine(decimalArray[j]);
    }
}
// input a fare then search and display

bool flag = false;
Console.WriteLine("enter the fare to search");
decimal number = Convert.ToDecimal(Console.ReadLine());
for (int i = 0; i < 10; i++)
{
    if (number == decimalArray[i])
    {
        Console.WriteLine("fare has been found");
        Console.WriteLine("position of the fare");
        Console.WriteLine(i);
        flag = true;
    }
}
if (flag != true)
{
    Console.WriteLine("name not found");
}

// minimum and maximum fares
if (decimalArray.Length > 0)
        {
            decimal min = decimalArray[0];
            decimal max = decimalArray[0];
            for (int i = 0; i < decimalArray.Length; i++)
            {
                if (max < decimalArray[i])
                {
                    decimal tmp = max;
                    max = decimalArray[i];
                    decimalArray[i] = max;
                }
                if (min > decimalArray[i])
                {
                    decimal tmp = min;
                    min = decimalArray[i];
                    decimalArray[i] = min;
                }
            }
            Console.WriteLine("minimum is {0}", min);
            Console.WriteLine("maximum is {0}", max);
        }
    