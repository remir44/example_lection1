Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine()!;

if(username.ToLower() == "кира")
{
    Console.WriteLine("Ура, это же КИРА!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}