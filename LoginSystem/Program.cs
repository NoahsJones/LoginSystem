namespace LoginSystem
{
    internal class Program
    {
        public static string[] Register()
        {
            Console.Write("Please input your desired name for your user: ");
            string registeredUserName = Console.ReadLine();
            Console.Write("Please input your desired password for your user: ");
            string registeredPassword = Console.ReadLine();

            string[] credentials = {registeredUserName, registeredPassword};
        
       
            bool keepInputPassword = true;
            while (keepInputPassword)
            {
                Console.Write("Please input your password again: ");
                string registeredPasswordAgain = Console.ReadLine();

                if (registeredPasswordAgain == registeredPassword)
                {
                    keepInputPassword = false;
                }
                else
                {
                    Console.WriteLine("You inputted your password incorrectly, try again... \n");
                }
            }
            return credentials;
        }

        public static void LoginIn(string username, string password)
        {
            Console.WriteLine($"Welcome, {username} you are logged in!");
        }
        
        static void Main(string[] args)
        {
            bool KeepLoggingIn = true;
            string[] userCredentials = Register();
            while (KeepLoggingIn)
            {
                Console.WriteLine("Do you have an account? ");
                string accountQuestion = Console.ReadLine();

                if (accountQuestion == "No" || accountQuestion == "no")
                {
                    Console.WriteLine("Yes you do quit complaining and type in your credentials...");
                }
                else if (accountQuestion == "Yes" || accountQuestion == "yes")
                {
                    string username = userCredentials[0];
                    string password = userCredentials[1];

                    LoginIn(username, password);
                    KeepLoggingIn = false;
                }
            }
        }
    }
}
