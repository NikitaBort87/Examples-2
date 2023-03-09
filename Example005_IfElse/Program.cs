System.Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура! Это же Маша! ");
}
else
{
    System.Console.Write("Привет, ");
    System.Console.WriteLine(username);
}