internal class Program
{
    private static void Main(string[] args)
    {
        int numberOfAttempt = 3;
        string password = "1234";

        Console.WriteLine("Добро пожаловать!");

        for (int i = 1; i <= numberOfAttempt; i++)
        {
            Console.WriteLine("Введите пароль доступа: ");
            string userInput = Console.ReadLine();

            if (password == userInput)
            {
                i = numberOfAttempt;
                Console.WriteLine("Ва ввели правильный пароль.\nПохоже, вы мой создатель.\nЖелаю успехов в дальнейшем обучении.");                
            }
            else
            {
                int attempt = numberOfAttempt - i;
                Console.WriteLine($"Ва ввели неправильный пароль.\nУ вас осталось {attempt} попытки(а).");
            }
        }
        Console.WriteLine("\nСеанс закончен.");
    }
}