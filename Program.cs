namespace Oldscholl_text_base_adventure_game_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;

            //Strings:
            string gender;

            do
            {
                Console.WriteLine("Place choose a gender as below: ");
                Console.WriteLine("Male / Female");

                gender = Console.ReadLine().ToUpper();

                if (gender == "MALE") correct = 1;

                if (gender == "FEMALE") correct = 1;
                else
                {

                }

            } while (correct == 0);
            
        }
    }
}