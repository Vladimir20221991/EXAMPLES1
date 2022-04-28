Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "машуля,артем")

{
    Console.WriteLine("Ура, это же Машуля!");
    Console.WriteLine("Ура, это же крутой вратарь Артем!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
