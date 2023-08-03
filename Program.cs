using System.Security.Cryptography.X509Certificates;

namespace Oldscholl_text_base_adventure_game_C_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ints:
            int correct = 0;           
            int enemyHealthPoints;
            int enemyMaximumDamage;

            //Strings:         
            string input;
            string enemyName;

            Player player = new Player();

            #region Character Cration
            do
            {
                Console.WriteLine("Place choose a gender as below: ");
                Console.WriteLine("Male / Female");

                player.playerGender = Console.ReadLine().ToUpper();

                if (player.playerGender == "FEMALE" || player.playerGender == "MALE" || player.playerGender == "F" || player.playerGender == "M")
                {
                    if (player.playerGender == "F") player.playerGender = "FEMALE";
                    if (player.playerGender == "M") player.playerGender = "MALE";

                    correct = 1;
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

                player.playerRace = Console.ReadLine().ToUpper();

                if (player.playerRace == "HUMAN" || player.playerRace == "H")
                {
                    player.playerRace = CheckForSingleLatherInput(nameof(player.playerRace), player.playerRace);

                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 1 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);

                }
                else if (player.playerRace == "DWARF" || player.playerRace == "D")
                {
                    player.playerRace = CheckForSingleLatherInput(nameof(player.playerRace), player.playerRace);

                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
                }
                else if (player.playerRace == "ELF" || player.playerRace == "E")
                {
                    player.playerRace = CheckForSingleLatherInput(nameof(player.playerRace), player.playerRace);

                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 2 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
                }
                else if (player.playerRace == "ORC" || player.playerRace == "O")
                {
                    player.playerRace = CheckForSingleLatherInput(nameof(player.playerRace), player.playerRace);

                    Console.WriteLine("This race gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 0 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
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

                player.playerClass = Console.ReadLine().ToUpper();

                if (player.playerClass == "WARRIOR" || player.playerClass == "W")
                {
                    player.playerClass = CheckForSingleLatherInput(nameof(player.playerClass), player.playerClass);

                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 2 Point");
                    Console.WriteLine("Ranged Weapons. + 0 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);

                }
                else if (player.playerClass == "HUNTER" || player.playerClass == "H")
                {
                    player.playerClass = CheckForSingleLatherInput(nameof(player.playerClass), player.playerClass);

                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 1 Point");
                    Console.WriteLine("Ranged Weapons. + 2 Point");
                    Console.WriteLine("Magical Attack. + 0 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
                }
                else if (player.playerClass == "MAGE" || player.playerClass == "M")
                {
                    player.playerClass = CheckForSingleLatherInput(nameof(player.playerClass), player.playerClass);

                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 1 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 2 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
                }
                else if (player.playerClass == "THIEF" || player.playerClass == "T")
                {
                    player.playerClass = CheckForSingleLatherInput(nameof(player.playerClass), player.playerClass);

                    Console.WriteLine("This class gives a bonuses to the following stats: ");
                    Console.WriteLine("One Handed Weapons. + 2 Point");
                    Console.WriteLine("Two Handed Weapons. + 0 Point");
                    Console.WriteLine("Ranged Weapons. + 1 Point");
                    Console.WriteLine("Magical Attack. + 1 Point");
                    Console.WriteLine("Is this the class you wish to play? Enter Yse/No below: ");
                    input = Console.ReadLine().ToUpper();

                    correct = CheckYesOrNo(correct, input);
                }
            } while (correct == 0);
            correct = 0;

            #endregion

            #region Bonuses

            #region Race Bonus

            if (player.playerRace == "HUMAN")
            {
                player.playerOneHandedWeaponSkill++;
                player.playerTwoHandedWeaponSkill++;
                player.playerRangedWeaponSkill++;
                player.playerMagicSkill++;
            }
            if (player.playerRace == "DWARF")
            {
                player.playerOneHandedWeaponSkill++;
                player.playerTwoHandedWeaponSkill += 2;
                player.playerRangedWeaponSkill++;
            }
            if (player.playerRace == "ELF")
            {
                player.playerOneHandedWeaponSkill++;
                player.playerRangedWeaponSkill += 2;
                player.playerMagicSkill++;
            }
            if (player.playerRace == "ORC")
            {
                player.playerOneHandedWeaponSkill += 2;
                player.playerTwoHandedWeaponSkill += 2;
            }

            #endregion

            #region Class Bonus

            if (player.playerClass == "WARRIOR")
            {
                player.playerOneHandedWeaponSkill += 2;
                player.playerTwoHandedWeaponSkill += 2;
            }
            if (player.playerClass == "HUNTER")
            {
                player.playerOneHandedWeaponSkill++;
                player.playerTwoHandedWeaponSkill++;
                player.playerRangedWeaponSkill += 2;
            }
            if (player.playerClass == "MAGE")
            {
                player.playerOneHandedWeaponSkill++;
                player.playerRangedWeaponSkill++;
                player.playerMagicSkill += 2;
            }
            if (player.playerClass == "THIEF")
            {
                player.playerOneHandedWeaponSkill += 2;
                player.playerRangedWeaponSkill++;
                player.playerMagicSkill++;
            }

            #endregion

            #endregion

            //Player Description
            Console.Clear();
            Console.WriteLine("You full character description, is:");
            Console.WriteLine("A {0} {1} {2}", player.playerGender, player.playerRace, player.playerClass);
            Console.WriteLine("One handed weapon skill points: {0}", player.playerOneHandedWeaponSkill);
            Console.WriteLine("Two handed weapon skill points: {0}", player.playerTwoHandedWeaponSkill);
            Console.WriteLine("Ranged weapon skill points: {0}", player.playerRangedWeaponSkill);
            Console.WriteLine("Magic attack skill points: {0}", player.playerMagicSkill);
            Console.ReadLine();



            #region Inventory

            player.inventory[1] = "a";
            player.inventory[2] = "b";
            player.inventory[3] = "snails";

            Console.Clear();
            Console.WriteLine("Inventory Test: type inventory below");
            input = Console.ReadLine().ToUpper();

            if (input == "INVENTORY" || input == "I")
            {
                Console.Clear();
                Console.WriteLine("You Inventory contains: ");
                for (player.arrayCount = 0; player.arrayCount < 20; player.arrayCount++)
                {
                    //int inventoryPosition = arrayCount +1;
                    Console.SetCursorPosition(0, player.arrayCount);
                    Console.WriteLine("{0}", player.inventory[player.arrayCount]);
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
                Console.WriteLine("You Health is at {0} Points, You Mana is at {1} Points", player.playerHealthPoints, player.playerManaPoints);
                Console.WriteLine("The {0}s Health is it {1} Points", enemyName, enemyHealthPoints);
                Console.WriteLine("Enter the number for the type attack that you wish to perform:");
                Console.WriteLine("1. One Handed Attack");
                Console.WriteLine("2. Two Handed Attack");
                Console.WriteLine("3. Ranged Weapon Attack");
                Console.WriteLine("4. Magical Attack");
                Console.Write("Your Choice: ");
                player.playerAttackType = int.Parse(Console.ReadLine());

                if (player.playerAttackType == 1)
                {
                    enemyHealthPoints = PlayerHitEnemy(player.playerOneHandedWeaponSkill, player.playerOneHandedWeaponDamage, enemyHealthPoints, enemyName);
                }

                if (player.playerAttackType == 2)
                {
                    enemyHealthPoints = PlayerHitEnemy(player.playerTwoHandedWeaponSkill, player.playerTwoHandedWeaponDamage, enemyHealthPoints, enemyName);
                }

                if (player.playerAttackType == 3)
                {
                    enemyHealthPoints = PlayerHitEnemy(player.playerRangedWeaponSkill, player.playerRangedWeaponDamage, enemyHealthPoints, enemyName);
                }

                if (player.playerAttackType == 4)
                {
                    enemyHealthPoints = PlayerHitEnemy(player.playerMagicSkill, player.playerMagicDamage, enemyHealthPoints, enemyName);
                }

                if (enemyHealthPoints > 0)
                {
                    Random enemyDamageRoll = new Random();
                    int randomEnemyDamageRoll = enemyDamageRoll.Next(0, enemyMaximumDamage + 1);
                    Console.WriteLine("The {0} strikes back, and deal {1} points of damage", enemyName, randomEnemyDamageRoll);
                    player.playerHealthPoints -= randomEnemyDamageRoll;
                    Console.ReadLine();
                }

            } while (player.playerHealthPoints > 0 && enemyHealthPoints > 0);

            if (enemyHealthPoints <= 0) enemyHealthPoints = 0;
            if (player.playerHealthPoints <= 0) player.playerHealthPoints = 0;

            Console.WriteLine("You Health is at {0} Points, You Mana is at {1} Points", player.playerHealthPoints, player.playerManaPoints);
            Console.WriteLine("The {0}s Health is it {1} Points", enemyName, enemyHealthPoints);
            //Console.WriteLine("Enter the number for the type attack that you wish to perform:");
            //Console.WriteLine("1. One Handed Attack");
            //Console.WriteLine("1. Two Handed Attack");
            //Console.WriteLine("1. Ranged Weapon Attack");
            //Console.WriteLine("1. Magical Attack");

            if (enemyHealthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You lost the battle");
                Console.ReadLine();
            }
            if (player.playerHealthPoints > 0)
            {
                Console.WriteLine("");
                Console.WriteLine(" - You win the battle");
                Console.ReadLine();
            }

            #endregion

            Console.ReadLine();
        }

        private static int PlayerHitEnemy(int playerCurrentSkill, int playerCurrentDamage, int enemyHealthPoints, string enemyName)
        {
            Random damageRoll = new Random();
            int randomDamageRoll = damageRoll.Next(0, playerCurrentDamage + 1);
            //Console.WriteLine("{0}", randomDamageRoll);
            Random skillPointRoll = new Random();
            int skillPointOutcome = skillPointRoll.Next(0, 11);
            if (skillPointOutcome > 6 && randomDamageRoll > 0)
            {
                randomDamageRoll = randomDamageRoll + playerCurrentSkill;
                Console.WriteLine("You did a critical hit, and added {0} Skill point of damage", playerCurrentSkill);
            }
            Console.WriteLine("You did {0} Damage to the {1}", randomDamageRoll, enemyName);
            enemyHealthPoints -= randomDamageRoll;
            return enemyHealthPoints;
        }

        private static int CheckYesOrNo(int correct, string input)
        {
            if (input == "YES" || input == "Y") correct = 1;
            if (input == "NO" || input == "N") correct = 0;
            return correct;
        }

        private static string CheckForSingleLatherInput(string parameterName, string value)
        {
            if (parameterName == "playerRace" && value.Length == 1)
            {
                switch (value)
                {
                    case "H":
                        return "HUMAN";
                    case "D":
                        return "DWARF";
                    case "E":
                        return "ELF";
                    case "O":
                        return "ORC";
                };
            }

            if (parameterName == "playerClass" && value.Length == 1)
            {
                switch (value)
                {
                    case "W":
                        return "WARRIOR";
                    case "H":
                        return "HUNTER";
                    case "M":
                        return "MAGE";
                    case "T":
                        return "THIEF";
                };
            }

            return value;
        }
    }
}