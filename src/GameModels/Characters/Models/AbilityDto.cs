using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels.Characters.Models
{
    public class AbilityDto
    {
        /// <summary>
        /// 等級
        /// LV
        /// </summary>
        public int Level { get; set; }
        /// <summary>
        /// 血量
        /// HP
        /// </summary>
        public double Health { get; set; }
        /// <summary>
        /// 魔力
        /// MP
        /// </summary>
        public double Magic { get; set; }
        /// <summary>
        /// 行動值
        /// AP
        /// </summary>
        public double ActionPoint { get; set; }
        /// <summary>
        /// 攻擊力(基礎傷害)
        /// STR
        /// </summary>
        public double Strength { get; set; }
        /// <summary>
        /// 智力
        /// Inte
        /// </summary>
        public double Intelligence { get; set; }
        /// <summary>
        /// 命中
        /// ACC
        /// </summary>
        public double Accuracy { get; set; }
        /// <summary>
        /// 幸運
        /// LUK
        /// </summary>
        public double Luck { get; set; }
        /// <summary>
        /// 靈巧,迴避
        /// AGI
        /// </summary>
        public double Agility { get; set; }
        /// <summary>
        /// 物理攻擊
        /// ATK
        /// </summary>
        public double  Attack { get; set; }
        /// <summary>
        /// 魔法傷害
        /// MATK
        /// </summary>
        public double Mattack { get; set; }
    }
}
