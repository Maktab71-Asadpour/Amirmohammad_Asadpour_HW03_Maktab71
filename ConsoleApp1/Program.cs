

//--------------- Part1 - Tamrin 4 ---------------
Console.WriteLine($"Enum strings are {ContactType.SMS.ToString()} and {ContactType.Email.ToString()}");


//--------------- Part1 - Tamrin 5 ---------------
ContactType[] enumArray = (ContactType[])Enum.GetValues(typeof(ContactType));


//--------------- Part1 - Tamrin 6 ---------------
string enumItem = ((ContactType)2).ToString();


//--------------- Part1 - Tamrin 7 ---------------
foreach (var item in Enum.GetValues(typeof(ContactType)))
{
    Console.WriteLine($"{item} = {(int)item}");
}


//--------------- Part1 - Tamrin 8 ---------------
Console.Write("Enter the name of ContactType item (Ignore Cases): ");
string inputStr = Console.ReadLine().Trim();
ContactType contactItem;
if (Enum.TryParse<ContactType>(inputStr, true, out contactItem)) //Ignore Cases
{
    Console.WriteLine($"{contactItem} = {(int)contactItem}");
}
else
{
    Console.WriteLine("Itemm not found!");
}


//--------------- Part1 - Tamrin 9 ---------------
foreach (ContactType item in Enum.GetValues(typeof(ContactType)))
{
    switch (item)
    {
        case ContactType.SMS:
            Console.WriteLine("This is SMS");
            break;
        case ContactType.Email:
            Console.WriteLine("This is Email");
            break;
            
    }
}