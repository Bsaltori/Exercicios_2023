// Modify the previous program such that only the users Alice and Bob are greeted with their names.

Console.WriteLine("What is your name? ");

string name = Console.ReadLine();

if (name == "Alice" || name == "Bob")
{
    Console.WriteLine("Olá " + name); 
}
