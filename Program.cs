namespace Oldscholl_text_base_adventure_game_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;
            int playerOneHanded = 0;
            int playerTwoHanded = 0;
            int playerRangedWeapon = 0;
            int playerMagic = 0;

            //Strings:
            string gender;
            string race;
            string classCh;

            #region Character Cration
            do
            {
                Console.WriteLine("Place choose a gender as below: ");
                Console.WriteLine("Male / Female");

                gender = Console.ReadLine().ToUpper();

                if (gender == "FEMALE" || gender == "MALE") correct = 1;
                else
                {

                }

            } while (correct == 0);
            correct = 0;

            #endregion

            #region Race Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Place choose a race as below: ");
                Console.WriteLine("Human");
                Console.WriteLine("Dwarf");
                Console.WriteLine("Elf");
                Console.WriteLine("Orc");
                Console.WriteLine("Your Choice: ");

                race = Console.ReadLine().ToUpper();

                if (race == "HUMAN" || race == "DWARF" || race == "ELF" || race == "ORC") correct = 1;
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            #endregion

            #region Class Creation:
            do
            {
                Console.Clear();
                Console.WriteLine("Place choose a class as below: ");
                Console.WriteLine("Warrior");
                Console.WriteLine("Hunter");
                Console.WriteLine("Mage");
                Console.WriteLine("Thief");
                Console.WriteLine("Your Choice: ");

                classCh = Console.ReadLine().ToUpper();

                if (classCh == "WARIOR" || classCh == "HUNTER" || classCh == "MAGE" || classCh == "THIEF") correct = 1;
                else
                {

                }
            } while (correct == 0);
            correct = 0;

            #endregion

            #region Bonuses

            #region Race Bonus

            if (race == "HUMAN")
            {
                playerOneHanded++;
                playerTwoHanded++;
                playerRangedWeapon++;
                playerMagic++;
            }
            if (race == "DWARF")
            {
                playerOneHanded++;
                playerTwoHanded += 2;
                playerRangedWeapon++;
            }
            if (race == "ELF")
            {
                playerOneHanded++;
                playerRangedWeapon += 2;
                playerMagic++;
            }
            if (race == "ORC")
            {
                playerOneHanded += 2;
                playerTwoHanded += 2;
            }

            #endregion

            #region Class Bonus

            if (race == "WARIOR")
            {
                playerOneHanded += 2;
                playerTwoHanded += 2;
            }
            if (race == "HUNTER")
            {
                playerOneHanded++;
                playerTwoHanded++;
                playerRangedWeapon += 2;
            }
            if (race == "MAGE")
            {
                playerOneHanded++;
                playerRangedWeapon++;
                playerMagic += 2;
            }
            if (race == "THIEF")
            {
                playerOneHanded += 2;
                playerRangedWeapon++;
                playerMagic++;
            }

            #endregion

            #endregion


        }
    }
}