using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using System;

namespace GameModels.Characters.Types
{
    /// <summary>
    /// 戰士
    /// </summary>
    public class Warrior : IOccupation
    {
        /// <summary>
        /// 戰士能力值
        /// </summary>
        /// <param name="ability"></param>
        /// <returns></returns>
        public AbilityDto Ability(AbilityDto ability)
        {
            throw new NotImplementedException();
        }

    }
}
