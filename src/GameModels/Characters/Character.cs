using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using GameModels.Characters.Models.enums;
using GameModels.Characters.Skills;
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
        private ISkill skill;
        public Character(OccupationEnum occupationEnum, ISkill skill)
        {
            this.occupation = GetOccupation(occupationEnum);
            this.skill = skill;
        }

        /// <summary>
        /// 取得職業
        /// </summary>
        /// <param name="occupationEnum"></param>
        /// <returns></returns>
        private IOccupation GetOccupation(OccupationEnum occupationEnum)
        {
            switch (occupationEnum)
            {
                case OccupationEnum.Warrior:
                    return new Warrior();
                case OccupationEnum.Tank:
                    return new Tank();
                case OccupationEnum.Mage:
                    return new Mage();
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
        /// 攻擊
        /// </summary>
        /// <param name="othersAbility">對手能力值</param>
        /// <param name="userAbility">攻擊者能力值</param>
        /// <returns></returns>
        public AbilityDto SkillAttack(AbilityDto othersAbility, ref AbilityDto userAbility)
        {
            //迴避
            if (skill.IsDodge(othersAbility, userAbility))
                throw new Exception($"對方躲過你的{skill.GetName}");

            //發動技能
            skill.UsingSkill(othersAbility, userAbility);

            //技能結果
            skill.AfterUsedSkill(userAbility);
            return othersAbility;
        }
    }
}
