// accept 10 passenger date of birth and display

Console.WriteLine("enter the dob of passenger as (dd/mm/yyy):");
DateTime[] dob = new DateTime[10];
for (int i = 0;i < dob.Length; i++)
{
    dob[i] = Convert.ToDateTime(Console.ReadLine());
  
}

for (int i = 0;i < dob.Length; i++)
{
    var today= DateTime.Now;
    var presentage= today.Year - dob[i].Year;
    Console.WriteLine(presentage);

    // age < 10,print as kid
    if(presentage < 10)
    {
        Console.WriteLine("Passenger with age {0} is kid", presentage);
    }
    
    // age>10 and age<30 print as youth
    else if (presentage >10 & presentage <30 )
    {
        Console.WriteLine("Passenger with age {0} is youth", presentage);
    }

    // age >30 and age <60 print as adult

    else if (presentage > 30 & presentage < 60)
    {
        Console.WriteLine(" Passenger with age {0} is Adult", presentage);
    }

    // age>60 as older
    else if (presentage > 60)
    {
        Console.WriteLine("Pssenger with age {0} is older", presentage);
    }


}

