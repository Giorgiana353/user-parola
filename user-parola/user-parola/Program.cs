namespace user_parola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string usernamec = "giorgi";
            const string parolac = "353";

            bool autentificare = false;

            while (!autentificare)
            {
                Console.WriteLine("Introduceti username: ");
                string username = Console.ReadLine();

                Console.WriteLine("Introduceti parola: ");
                string parola = Console.ReadLine();

                if (username == usernamec && parola == parolac)
                {
                    Console.WriteLine("Bine ai venit, " + usernamec);
                    autentificare = true;
                }
                else
                {
                    Console.WriteLine("gresit");
                }

            }
        }
    }
}
    
