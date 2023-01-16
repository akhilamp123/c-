//using System.Collections;

using System.Collections.Generic;

Console.WriteLine("Enter the names of 6 passenger: ");
string[] str = new string[6];
for (int i = 0; i < str.Length; i++)
{
    str[i] = Console.ReadLine();
}


// sort array in ascending order
Console.WriteLine("sort array in ascending order");
Array.Sort(str);
for (int i = 0; i < str.Length; i++)
{
    Console.WriteLine(str[i] + " ");
}


// length of names in each element

Console.WriteLine("Lengths:");
for (int i = 0; i < str.Length; i++)
{
    Console.Write("length of each element:");
    Console.WriteLine(str[i].Length);
}




//input a name  and search in array and display
bool flag = false;
Console.WriteLine("enter the name to search");
var name = Console.ReadLine();
for (int i = 0; i < 10; i++)
{
    if (name == str[i])
    {
        Console.WriteLine("name has been found");
        Console.WriteLine("position of the name");
        Console.WriteLine(i);
        flag = true;
    }
}
if (flag != true)
{
    Console.WriteLine("name not found");
}


// reverse order
Console.WriteLine(" names in reverse order:");
for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i] + " ");
}

// split the names at space and print each elemnt
Console.WriteLine("space separated strings");
for (int i = 0; i < 10; i++)
{
    var words = str[i].Split(' ');
    Array.ForEach(words, Console.WriteLine);
}

// find duplicate entries

Console.WriteLine("duplicate entries");
for (int i = 0; i < str.Length; i++)
{
    for (int j = i + 1; j < str.Length; j++)
    {
        if (str[i] == str[j])
            Console.WriteLine(str[j]);
    }
}  
   