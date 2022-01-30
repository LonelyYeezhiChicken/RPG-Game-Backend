using GameModels.Characters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels.Characters.Interfaces
{
    public interface ISkill
    {
        /// <summary>
        /// 技能id
        /// </summary>
        string GetId { get; }
        /// <summary>
        /// 招式名稱
        /// </summary>
        /// <returns></returns>
        string GetName { get; }
        /// <summary>
        /// 冷卻時間
        /// 單位為秒
        /// </summary>
        /// <returns></returns>
        double GetCD { get; }
        /// <summary>
        /// 描述
        /// </summary>
        string GetDescription { get; }
        /// <summary>
        /// 是否迴避
        /// </summary>
        /// <param name="othersAbility">對方能力值</param>
        /// <param name="userAbility">我方能力值</param>
        /// <returns>是否迴避</returns>
        bool IsDodge(AbilityDto othersAbility, AbilityDto userAbility);
        /// <summary>
        /// 使用技能
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <returns>攻擊或加護後的能力值</returns>
        AbilityDto UsingSkill(AbilityDto othersAbility, AbilityDto userAbility);
        /// <summary>
        /// 使用技能
        /// 道具增幅
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <param name="props">道具</param>
        /// <returns>攻擊或加護後的能力值</returns>
        AbilityDto UsingSkillBy(AbilityDto othersAbility, AbilityDto userAbility, string props);
        /// <summary>
        /// 使用技能
        /// 詠唱增幅，或附魔
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <param name="chant">詠唱</param>
        /// <returns>攻擊或加護後的能力值</returns>
        AbilityDto UsingSkill(AbilityDto othersAbility, AbilityDto userAbility, string chant);
        /// <summary>
        /// 使用技能後
        /// </summary>
        /// <param name="userAbility">使用技能錢的能力值</param>
        /// <returns>施展技能後的能力</returns>
        AbilityDto AfterUsedSkill(AbilityDto userAbility);
    }
}
