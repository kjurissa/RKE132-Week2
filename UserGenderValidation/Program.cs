// See https://aka.ms/new-console-template for more information
//rakendus küsib sugu
//küsib perekonnanime
//rakendus tervitab kasutajat
//

Console.WriteLine("Vali oma sugu (m/n): ");

char userGender = Char.Parse(Console.ReadLine()); // loeb konsoolist string ehk sõne
Console.WriteLine("Palun sisesta oma perekonnanimi: ");
string userLastName = Console.ReadLine();


if (userGender == 'm')
{
    Console.WriteLine($"Tere, Mr.{userLastName}");
}
else if (userGender == 'n')
{
    Console.WriteLine($"Tere, Ms.{userLastName}");
}
else
{
    Console.WriteLine($"Tere {userLastName}");
}


//Console.WriteLine($"Tere, {userGender}");
