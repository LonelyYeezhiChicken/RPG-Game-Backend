﻿using GameModels.Characters.Helper;
using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;

namespace GameModels.Characters.Types
{
    /// <summary>
    /// 坦克    
    /// </summary>
    public class Tank : IOccupation
    {
        /// <summary>
        /// 坦克能力值
        /// HP:2倍
        /// luck:2倍
        /// 敏捷:0.8倍
        /// </summary>
        /// <param name="ability">基本數值</param>
        /// <returns></returns>
        public AbilityDto Ability(AbilityDto ability)
        {
            ability.Dexterity = FormulaHelper.AbilityRatio(ability.Dexterity, 0.8);
            ability.Health = FormulaHelper.AbilityRatio(ability.Health, 2);
            ability.Luck = FormulaHelper.AbilityRatio(ability.Luck, 2);
            return ability;
        }
    }
}
