using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Validador de E-mail");
        Console.WriteLine("--------------------");

        while (true)
        {
            Console.WriteLine("Digite '1' para verificar o e-mail ou '0' para sair:");
            var type = Console.ReadLine();

            if (type == "0")
            {
                Console.WriteLine("Obrigado! O programa será encerrado em 2 segundos...");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else if (type == "1")
            {
                while (true)
                {
                    Console.Write("Digite um e-mail para validar (ou '0' para encerrar): ");
                    string email = Console.ReadLine();

                    if (email.ToLower() == "0")
                    {
                        Console.WriteLine("Obrigado! O programa será encerrado em 2 segundos...");
                        Thread.Sleep(2000);
                        Environment.Exit(0);
                    }

                    if (IsValidEmail(email))
                    {
                        Console.WriteLine($"O e-mail fornecido {email} é válido!");
                    }
                    else
                    {
                        Console.WriteLine($"O e-mail fornecido {email} é inválido!");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Comando '{type}' inválido.");
                Console.WriteLine("Retornando ao menu principal...\n");
            }
        }
    }

    static bool IsValidEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        Regex regex = new Regex(pattern);

        return regex.IsMatch(email);
    }
}
