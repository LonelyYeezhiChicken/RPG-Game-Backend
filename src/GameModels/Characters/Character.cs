using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using GameModels.Characters.Models.enums;
using GameModels.Characters.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels.Characters
{
    /// <summary>
    /// 角色資訊
    /// </summary>
    public class Character
    {
        private IOccupation occupation;

        public Character(OccupationEnum occupationEnum)
        {
            switch (occupationEnum)
            {
                case OccupationEnum.Warrior:
                    occupation = new Warrior();
                    break;
                case OccupationEnum.Tank:
                    occupation = new Tank();
                    break;
                case OccupationEnum.Mage:
                    occupation = new Mage();
                    break;
                default:
                    throw new Exception("無此職業");
            }
        }
        /// <summary>
        /// 建立角色
        /// 隨機產生數值
        /// </summary>
        /// <returns></returns>
        public AbilityDto Create()
        {
            AbilityDto ability = new AbilityDto();
            Random random = new Random();
            ability.Level = 1;
            ability.Health = random.Next(1000, 2000);
            ability.Magic = random.Next(500, 1000);
            ability.ActionPoint = random.Next(100, 500);
            ability.Strength = random.Next(30, 100);
            ability.Intelligence = random.Next(30, 100);
            ability.Accuracy = random.Next(30, 100);
            ability.Luck = random.Next(30, 100);
            ability.Agility = random.Next(30, 100);
            ability.Attack = random.Next(30, 100);
            ability.Mattack = random.Next(30, 100);
            return occupation.Ability(ability);
        }

        /// <summary>
        /// 角色技能
        /// </summary>
        public void Skills()
        {

        }

        /// <summary>
        /// 能力值
        /// </summary>
        public void Ability()
        {

        }

    }
}
