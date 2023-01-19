// 7. accept passenger name and total miles travelled

Console.WriteLine(" enter the name of the passenger:");
string name = Console.ReadLine();

Console.WriteLine("enter the total miles travelled:");
int totalmiles = Convert.ToInt32(Console.ReadLine());

if(totalmiles > 10000 && totalmiles < 20000)
{
    Console.WriteLine("The passenger is awarded 10 flyer points");
}
else if (totalmiles >20000 && totalmiles < 50000)
{
    Console.WriteLine("The passenger is awarded 20 flyer points");
}
else if (totalmiles > 50000 && totalmiles < 100000)
{
    Console.WriteLine("The passenger is awarded 30 flyer points");
}
else if(totalmiles > 100000)
{
    Console.WriteLine("The passenger is awarded 50 flyer points");
}

