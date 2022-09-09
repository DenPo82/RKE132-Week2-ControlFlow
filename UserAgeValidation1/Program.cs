// See https://aka.ms/new-console-template for more information
//Programm küsib kasutajalt sisestada tema vanuse
//Kui vanus on <13, siis kuvatakse "You're too young to use Instagram", muul juhul "Welcome to Instagram"

Console.WriteLine("Enter Your age:");

int userAge = Int32.Parse(Console.ReadLine());

if(userAge >= 13)
{
    Console.WriteLine("Welcome to Istagram!");
} else
{
    Console.WriteLine("You're too young to use Instagram!");
}
