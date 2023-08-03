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
            int arrayCount = 0;

            //Strings:
            string gender;
            string race;
            string classCh;
            string[] inventory = new string[20];
            string input;

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

                if (race == "HUMAN")
                {
                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 1 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;

                }
                else if (race == "DWARF")
                {
                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
                }
                else if (race == "ELF")
                {
                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 2 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
                }
                else if (race == "ORC")
                {
                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 0 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
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

                if (classCh == "WARIOR")
                {
                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 0 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;

                }
                else if (classCh == "HUNTER")
                {
                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 1 Point");
                    Console.WriteLine("Ranged Weapons. + 2 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
                }
                else if (classCh == "MAGE")
                {
                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
                }
                else if (classCh == "THIEF")
                {
                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    if (input == "YES") correct = 1;
                    if (input == "NO") correct = 0;
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

            #region Inventory

            inventory[1] = "a";
            inventory[2] = "b";
            inventory[3] = "snails";

            Console.Clear();
            Console.WriteLine("Inventory Test: type inventory below");
            input = Console.ReadLine().ToUpper();

            if (input == "INVENTORY")
            {
                Console.Clear();
                Console.WriteLine("You Inventory contains: ");
                for (arrayCount = 0; arrayCount < 20; arrayCount++)
                {
                    //int inventoryPossition = arrayCount +1;
                    Console.SetCursorPosition(0, arrayCount);
                    Console.WriteLine("{0}", inventory[arrayCount]);
                }
            }
            else
            {

            }

            Console.ReadLine();

            #endregion
        }
    }
}