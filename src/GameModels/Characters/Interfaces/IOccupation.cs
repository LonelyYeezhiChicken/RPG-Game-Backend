using GameModels.Characters.Models;

namespace GameModels.Characters.Interfaces
{
    public interface IOccupation
    {
        /// <summary>
        /// 能力值
        /// </summary>
        /// <param name="abilityDto">輸入角色能力值</param>
        /// <returns>計算過後的角色能力值</returns>
        AbilityDto Ability(AbilityDto ability);

        /// <summary>
        /// 特殊技能
        /// </summary>
        //void Skills();


    }
}
