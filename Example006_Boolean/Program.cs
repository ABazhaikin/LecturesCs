Console.Write("Input username: ");
string username = Console.ReadLine();

if (username.ToLower() == "maria")
{
    Console.WriteLine("Horray! That's Maria");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}