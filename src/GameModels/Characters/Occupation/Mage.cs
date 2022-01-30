using GameModels.Characters.Helper;
using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;

namespace GameModels.Characters.Types
{
    /// <summary>
    /// 法師
    /// </summary>
    public class Mage : IOccupation
    {
        /// <summary>
        /// 法師能力值
        /// HP:0.8倍
        /// MP:1.5倍
        /// 智力:1.5倍
        /// 魔法攻擊:2倍
        /// </summary>
        /// <param name="ability">基本數值</param>
        /// <returns></returns>
        public AbilityDto Ability(AbilityDto ability)
        {
            ability.Intelligence = FormulaHelper.AbilityRatio(ability.Intelligence, 1.5);
            ability.Magic = FormulaHelper.AbilityRatio(ability.Magic, 1.5);
            ability.Health = FormulaHelper.AbilityRatio(ability.Health, 0.8);
            ability.Mattack = FormulaHelper.AbilityRatio(ability.Mattack, 2);
            return ability;
        }
    }
}
