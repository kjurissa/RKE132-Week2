// See https://aka.ms/new-console-template for more information


//küsib vanust

Console.WriteLine("Sisesta oma vanus: ");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Tere tulemast Instagrami!");
}
else
{
    Console.WriteLine("Sa oled liiga noor Instagrami kasutamiseks!");
}