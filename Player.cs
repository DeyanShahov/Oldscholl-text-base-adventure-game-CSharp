namespace Oldscholl_text_base_adventure_game_C_
{
    public class Player
    {
        public int playerOneHandedWeaponSkill = 0;
        public int playerTwoHandedWeaponSkill = 0;
        public int playerRangedWeaponSkill = 0;
        public int playerMagicSkill = 0;
        public int arrayCount = 0;
        public int playerAttackType = 0;
        public int playerOneHandedWeaponDamage = 2;
        public int playerTwoHandedWeaponDamage = 2;
        public int playerRangedWeaponDamage = 2;
        public int playerMagicDamage = 2;
        public int playerHealthPoints = 20;
        public int playerManaPoints = 12;
        public int playerInventoryMoney = 0;
        public int playerInventoryExperience = 0;
        public int questRewardExp;
        public int questRewardGold;
        public int playerQuestProgress = 0;
        public int playerQuestGoal;
        public int playerExperience = 0;

        public string playerGender;
        public string playerRace;
        public string playerClass;
        public string[] inventory = new string[20];
        public string playerQuest = "";
        public string questAccepted;
        public string playerQuestEnemy;


    }
}
