using GameModels.Characters.Helper;
using GameModels.Characters.Interfaces;
using GameModels.Characters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels.Characters.Skills
{
    public class StrAttack : ISkill
    {
        /// <summary>
        /// 技能id
        /// </summary>
        public string GetId => "StrAttack";
        /// <summary>
        /// 招式名稱
        /// </summary>
        /// <returns></returns>
        public string GetName => "打你一拳";
        /// <summary>
        /// 冷卻時間
        /// 單位為秒
        /// </summary>
        /// <returns></returns>
        public double GetCD => 0.5;
        /// <summary>
        /// 描述
        /// </summary>
        public string GetDescription => throw new NotImplementedException();
        /// <summary>
        /// 使用技能
        /// 傷害 : 基礎攻擊力 + 物理攻擊
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <returns>攻擊或加護後的能力值</returns>
        public AbilityDto UsingSkill(AbilityDto othersAbility, AbilityDto userAbility)
        {
            //計算傷害
            int damage = FormulaHelper.GetDamage(userAbility.Strength, userAbility.Attack);

            //是否被迴避
            if (FormulaHelper.IsDodge(damage, Convert.ToInt32(userAbility.Accuracy), Convert.ToInt32(othersAbility.Agility)))
            {
                throw new Exception($"對方躲掉了{GetName}");
            }

            //扣血
            othersAbility.Health = damage - othersAbility.Health;

            return othersAbility;
        }
        /// <summary>
        /// 使用技能(暫無)
        /// 道具增幅
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <param name="props">道具</param>
        /// <returns>攻擊或加護後的能力值</returns>
        public AbilityDto UsingSkill(AbilityDto othersAbility, AbilityDto userAbility, string chant)
        {
            throw new Exception("功能維修中....");
        }
        /// <summary>
        /// 使用技能(暫無)
        /// 詠唱增幅，或附魔
        /// </summary>
        /// <param name="othersAbility">被使用對象的能力值</param>
        /// <param name="userAbility">使用者的能力值</param>
        /// <param name="chant">詠唱</param>
        /// <returns>攻擊或加護後的能力值</returns>
        public AbilityDto UsingSkillBy(AbilityDto othersAbility, AbilityDto userAbility, string props)
        {
            throw new Exception("功能維修中....");
        }

        /// <summary>
        /// 使用技能後
        /// AP-5
        /// </summary>
        /// <param name="userAbility">使用技能錢的能力值</param>
        /// <returns>施展技能後的能力</returns>
        public AbilityDto AfterUsedSkill(AbilityDto userAbility)
        {
            userAbility.ActionPoint = userAbility.ActionPoint - 5;
            return userAbility;
        }
    }
}
