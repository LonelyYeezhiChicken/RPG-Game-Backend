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
        public int Health { get; set; }
        /// <summary>
        /// 魔力
        /// MP
        /// </summary>
        public int Magic { get; set; }
        /// <summary>
        /// 行動值
        /// AP
        /// </summary>
        public int ActionPoint { get; set; }
        /// <summary>
        /// 攻擊力
        /// STR
        /// </summary>
        public int Strength { get; set; }
        /// <summary>
        /// 智力
        /// INT
        /// </summary>
        public int Intelligence { get; set; }
        /// <summary>
        /// 敏捷
        /// DEX
        /// </summary>
        public int Dexterity { get; set; }
        /// <summary>
        /// 幸運
        /// LUK
        /// </summary>
        public int Luck { get; set; }
        /// <summary>
        /// 靈巧
        /// AGI
        /// </summary>
        public int Agility { get; set; }
    }
}
