using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameModels.Characters.Helper
{
    /// <summary>
    /// 各式公式
    /// </summary>
    public class FormulaHelper
    {
        /// <summary>
        /// 能力值倍率計算
        /// </summary>
        /// <param name="input">基礎能力</param>
        /// <param name="ratio">倍率</param>
        /// <returns></returns>
        public static double AbilityRatio(double input, double ratio)
        {
            return input * ratio;
        }
    }
}
