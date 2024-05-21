namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidatePassword("Sal1am2&"));

        }

        //TASK---1

        static bool ValidatePassword(string password)
        {
            bool digit = false;
            bool Character = false;

            if (password.Length < 8)
            {
                return false;
            }
            else if (!char.IsUpper(password[0]))
            {
                return false;
            }

            foreach (char a in password)
            {
                if (char.IsDigit(a))
                {
                    digit = true;
                }
                else if (char.IsLetterOrDigit(a))
                {
                    Character = true;
                }
                else if (digit && Character)
                {
                    return true;
                }

            }
            return false;

        }
    }
}
