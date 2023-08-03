namespace Oldscholl_text_base_adventure_game_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;
            int playerOneHandedWeaponSkill = 0;
            int playerTwoHandedWeaponSkill = 0;
            int playerRangedWeaponSkill = 0;
            int playerMagicSkill = 0;
            int arrayCount = 0;
            int playerAttackType = 0;
            int playerOneHandedWeaponDanage = 2;
            int playerTwoHandedWeaponDanage = 2;
            int playerRangedWeaponDamge = 2;
            int playerMagicDamage = 2;
            int playerHealthPoints = 20;
            int playerManaPoints = 12;
            int enemyHealthPoints;
            int enemyMaximumDamage;

            //Strings:
            string playerGender;
            string playerRace;
            string playerClass;
            string[] inventory = new string[20];
            string input;
            string enemyName;

            #region Character Cration
            do
            {
                Console.WriteLine("Place choose a gender as below: ");
                Console.WriteLine("Male / Female");

                playerGender = Console.ReadLine().ToUpper();

                if (playerGender == "FEMALE" || playerGender == "MALE") correct = 1;
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

                playerRace = Console.ReadLine().ToUpper();

                if (playerRace == "HUMAN")
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
                else if (playerRace == "DWARF")
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
                else if (playerRace == "ELF")
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
                else if (playerRace == "ORC")
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

                playerClass = Console.ReadLine().ToUpper();

                if (playerClass == "WARIOR")
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
                else if (playerClass == "HUNTER")
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
                else if (playerClass == "MAGE")
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
                else if (playerClass == "THIEF")
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

            if (playerRace == "HUMAN")
            {
                playerOneHandedWeaponSkill++;
                playerTwoHandedWeaponSkill++;
                playerRangedWeaponSkill++;
                playerMagicSkill++;
            }
            if (playerRace == "DWARF")
            {
                playerOneHandedWeaponSkill++;
                playerTwoHandedWeaponSkill += 2;
                playerRangedWeaponSkill++;
            }
            if (playerRace == "ELF")
            {
                playerOneHandedWeaponSkill++;
                playerRangedWeaponSkill += 2;
                playerMagicSkill++;
            }
            if (playerRace == "ORC")
            {
                playerOneHandedWeaponSkill += 2;
                playerTwoHandedWeaponSkill += 2;
            }

            #endregion

            #region Class Bonus

            if (playerRace == "WARIOR")
            {
                playerOneHandedWeaponSkill += 2;
                playerTwoHandedWeaponSkill += 2;
            }
            if (playerRace == "HUNTER")
            {
                playerOneHandedWeaponSkill++;
                playerTwoHandedWeaponSkill++;
                playerRangedWeaponSkill += 2;
            }
            if (playerRace == "MAGE")
            {
                playerOneHandedWeaponSkill++;
                playerRangedWeaponSkill++;
                playerMagicSkill += 2;
            }
            if (playerRace == "THIEF")
            {
                playerOneHandedWeaponSkill += 2;
                playerRangedWeaponSkill++;
                playerMagicSkill++;
            }

            #endregion

            #endregion

            //Player Description
            Console.Clear();
            Console.WriteLine("You full character description, is:");
            Console.WriteLine("A {0} {1} {2}", playerGender, playerRace, playerClass);
            Console.WriteLine("One handed weapon skill points: {0}", playerOneHandedWeaponSkill);
            Console.WriteLine("Two handed weapon skill points: {0}", playerTwoHandedWeaponSkill);
            Console.WriteLine("Ranged weapon skill points: {0}", playerRangedWeaponSkill);
            Console.WriteLine("Magic attack skill points: {0}", playerMagicSkill);
            Console.ReadLine();



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
                    //int inventoryPosition = arrayCount +1;
                    Console.SetCursorPosition(0, arrayCount);
                    Console.WriteLine("{0}", inventory[arrayCount]);
                }
            }
            else
            {

            }

            Console.ReadLine();

            #endregion


            //Enemy declair system
            enemyName = "Rat";
            enemyHealthPoints = 12;
            enemyMaximumDamage = 2;


            #region Combat System

            //Random number between 0 and 100 ( 100 not included )
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            do
            {
                correct = 0;
                Console.Clear();
                Console.WriteLine("You Health is at {0} Points, You Mana is at {1} Points", playerHealthPoints, playerManaPoints);
                Console.WriteLine("The {0}s Health is it {1} Points", enemyName, enemyHealthPoints);
                Console.WriteLine("Enter the number for the type attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("1. Two Handed Attack");
                Console.WriteLine("1. Ranged Weapon Attack");
                Console.WriteLine("1. Magical Attack");
                playerAttackType = int.Parse(Console.ReadLine());
                if (playerAttackType == 1)
                {
                    Random damageRoll = new Random();
                    int randomDamageRoll = damageRoll.Next(0, playerOneHandedWeaponDanage);
                    Console.WriteLine("{0}", randomDamageRoll);
                    Random skillPointRoll = new Random();
                    int skillPointOutcome = skillPointRoll.Next(0, 11);
                    if (skillPointOutcome > 6 && randomDamageRoll > 0)
                    {
                        randomDamageRoll = randomDamageRoll + playerOneHandedWeaponSkill;
                        Console.WriteLine("You did a critical hit, and added {0} Skill point of damage", playerOneHandedWeaponSkill);                    
                    }
                    Console.WriteLine("You did {0} Damage to the {1}", randomDamageRoll, enemyName);
                    enemyHealthPoints -= randomDamageRoll;
                }

                if (playerAttackType == 2)
                {
                    Random damageRoll = new Random();
                    int randomDamageRoll = damageRoll.Next(0, playerTwoHandedWeaponDanage);
                    Console.WriteLine("{0}", randomDamageRoll);
                    Random skillPointRoll = new Random();
                    int skillPointOutcome = skillPointRoll.Next(0, 11);
                    if (skillPointOutcome > 6 && randomDamageRoll > 0)
                    {
                        randomDamageRoll = randomDamageRoll + playerTwoHandedWeaponSkill;
                        Console.WriteLine("You did a critical hit, and added {0} Skill point of damage", playerTwoHandedWeaponSkill);
                    }

                    Console.WriteLine("You did {0} Damage to the {1}", randomDamageRoll, enemyName);
                    enemyHealthPoints -= randomDamageRoll;
                }

                if (playerAttackType == 3)
                {
                    Random damageRoll = new Random();
                    int randomDamageRoll = damageRoll.Next(0, playerRangedWeaponDamge);
                    Console.WriteLine("{0}", randomDamageRoll);
                    Random skillPointRoll = new Random();
                    int skillPointOutcome = skillPointRoll.Next(0, 11);
                    if (skillPointOutcome > 6 && randomDamageRoll > 0)
                    {
                        randomDamageRoll = randomDamageRoll + playerRangedWeaponSkill;
                        Console.WriteLine("You did a critical hit, and added {0} Skill point of damage", playerRangedWeaponSkill);
                    }

                    Console.WriteLine("You did {0} Damage to the {1}", randomDamageRoll, enemyName);
                    enemyHealthPoints -= randomDamageRoll;
                }

                if (playerAttackType == 4)
                {
                    Random damageRoll = new Random();
                    int randomDamageRoll = damageRoll.Next(0, playerMagicDamage);
                    Console.WriteLine("{0}", randomDamageRoll);
                    Random skillPointRoll = new Random();
                    int skillPointOutcome = skillPointRoll.Next(0, 11);
                    if (skillPointOutcome > 6 && randomDamageRoll > 0)
                    {
                        randomDamageRoll = randomDamageRoll + playerMagicSkill;
                        Console.WriteLine("You did a critical hit, and added {0} Skill point of damage", playerMagicSkill);
                    }

                    Console.WriteLine("You did {0} Damage to the {1}", randomDamageRoll, enemyName);
                    enemyHealthPoints -= randomDamageRoll;
                }

                if (enemyHealthPoints > 0)
                {
                    Random enemyDamageRoll = new Random();
                    int randomEnemyDamageRoll = enemyDamageRoll.Next(0, enemyMaximumDamage);
                    Console.WriteLine("The {0} strikes back, and deal {1} points of damage", enemyName, randomEnemyDamageRoll);
                    playerHealthPoints -= randomEnemyDamageRoll;
                    Console.ReadLine();
                }

                Console.ReadLine();

            } while (playerHealthPoints > 0 && enemyHealthPoints > 0);

            if (enemyHealthPoints <= 0) enemyHealthPoints = 0;
            if (playerHealthPoints <= 0) playerHealthPoints = 0;

            Console.WriteLine("You Health is at {0} Points, You Mana is at {1} Points", playerHealthPoints, playerManaPoints);
            Console.WriteLine("The {0}s Health is it {1} Points", enemyName, enemyHealthPoints);
            Console.WriteLine("Enter the number for the type attack that you wish to perform:");
            Console.WriteLine("1. One Handed Attack");
            Console.WriteLine("1. Two Handed Attack");
            Console.WriteLine("1. Ranged Weapon Attack");
            Console.WriteLine("1. Magical Attack");

            if (enemyHealthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle");
                Console.ReadLine();
            }
            if (playerHealthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You win the battle");
                Console.ReadLine();
            }

            #endregion


            Console.ReadLine();
        }
    }
}