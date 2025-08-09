Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "снежка")
{
    Console.WriteLine("Ура, это же СНЕЖКА");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}