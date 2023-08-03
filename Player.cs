using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string playerGender;
        public string playerRace;
        public string playerClass;
        public string[] inventory = new string[20];
    }
}
