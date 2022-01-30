using GameModels.Characters.Helper;
using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;

namespace GameModels.Characters.Types
{
    /// <summary>
    /// 戰士
    /// </summary>
    public class Warrior : IOccupation
    {
        /// <summary>
        /// 戰士能力值
        /// 物理攻擊力:1.5倍
        /// Ap:1.5倍
        /// HP:1.5倍
        /// </summary>
        /// <param name="ability">基本數值</param>
        /// <returns></returns>
        public AbilityDto Ability(AbilityDto ability)
        {
            ability.Attack = FormulaHelper.AbilityRatio(ability.Attack, 1.5);
            ability.ActionPoint = FormulaHelper.AbilityRatio(ability.ActionPoint, 1.5);
            ability.Health = FormulaHelper.AbilityRatio(ability.Health, 1.5);
            return ability;
        }

    }
}
