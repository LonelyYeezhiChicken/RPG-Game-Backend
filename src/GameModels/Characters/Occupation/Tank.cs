using GameModels.Characters.Helper;
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
        /// 迴避: 1.5倍
        /// 命中:0.8倍
        /// </summary>
        /// <param name="ability">基本數值</param>
        /// <returns></returns>
        public AbilityDto Ability(AbilityDto ability)
        {
            ability.Accuracy = FormulaHelper.AbilityRatio(ability.Accuracy, 0.8);
            ability.Health = FormulaHelper.AbilityRatio(ability.Health, 2);
            ability.Luck = FormulaHelper.AbilityRatio(ability.Luck, 2);
            ability.Agility = FormulaHelper.AbilityRatio(ability.Agility, 1.5);
            return ability;
        }
    }
}
