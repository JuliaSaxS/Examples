Console.Write("Input your username: ");
string username = Console.ReadLine();

if (username.ToLower() == "mary")
{
    Console.WriteLine("Hurrah, it's MARY!");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}